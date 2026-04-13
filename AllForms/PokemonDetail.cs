using 訓練家管理系統.DTOs;
using 訓練家管理系統.Models;
using 訓練家管理系統.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訓練家管理系統.AllForms
{
    public partial class PokemonDetail : Form
    {
        private int currentPokemonID;
        private PokemonModelEx currentPokemon;
        private FormMode currentMode;
        private List<MoveDTOs> AllAvailableMove = new List<MoveDTOs>();
        // 定義畫面的兩種狀態
        public enum FormMode
        {
            ViewOnly, // 搜尋模式：只能看、不能改
            Edit,      // 管理模式：可以修改、刪除
            ADD        // 新增模式：空白頁面
        }

        public PokemonDetail(int currentPokemonID, FormMode currentMode)
        {
            InitializeComponent();
            this.currentPokemonID = currentPokemonID;
            this.currentMode = currentMode;

            LoadPokemonDetail(currentPokemonID);
            // 根據模式調整 UI
            ApplyModeSettings();
        }
        public PokemonDetail(FormMode currentMode)
        {
            InitializeComponent();
            this.currentMode = currentMode;

            ApplyModeSettings();
            if (currentMode == FormMode.ADD)
            {
                InitAddModeData();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            cboHP.Visible = true;
            cboAtk.Visible = true;
            cboDef.Visible = true;
            cboSp.Visible = true;
            cboVel.Visible = true;

            //  編輯模式：解鎖輸入框，讓使用者可以修改招式、暱稱等
            SetTextBoxReadOnly(false);
            UpdateMove(txtNo.Text);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtLv.Text) || string.IsNullOrEmpty(cboHP.Text) || string.IsNullOrEmpty(cboAtk.Text) || string.IsNullOrEmpty(cboDef.Text) || string.IsNullOrEmpty(cboSp.Text) || string.IsNullOrEmpty(cboVel.Text))
                {
                    MessageBox.Show("等級、能力值欄位不可空白，請重新輸入");
                    return;
                }

                PokemonRepositores repo = new PokemonRepositores();
                PokemonDetailDTOs detailDTOs = new PokemonDetailDTOs
                {
                    ID = currentPokemonID,
                    PokemonNo = cboNo.Text,
                    PokemonName = txtName.Text,
                    nickname = txtNickName.Text,
                    Owner = UserSession.currentUser.ID,
                    Level = Convert.ToInt32(txtLv.Text),
                    Sex = cboGender.Text,
                    firstMove = cboFM.Text,
                    secondMove = cboSM.Text,
                    thirdMove = cboTM.Text,
                    fourthMove = cboLM.Text,
                    hpIV = Convert.ToInt32(cboHP.Text),
                    atkIV = Convert.ToInt32(cboAtk.Text),
                    defIV = Convert.ToInt32(cboDef.Text),
                    spIV = Convert.ToInt32(cboSp.Text),
                    velIV = Convert.ToInt32(cboVel.Text),
                    UpdatedBy = UserSession.currentUser.TrainerName
                };


                if (currentMode == FormMode.ADD)
                {
                    if (repo.NewPokemon(detailDTOs))
                    {
                        MessageBox.Show("儲存成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("儲存失敗");
                        return;
                    }
                }
                else if (currentMode == FormMode.Edit)
                {
                    if (repo.UpdatePokemon(detailDTOs))
                    {
                        MessageBox.Show("儲存成功");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("儲存失敗");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫儲存失敗" + ex.Message);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("確認刪除嗎?", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;
            try
            {
                PokemonRepositores repo = new PokemonRepositores();
                bool isSuccess = repo.DeletePokemon(currentPokemonID);
                if (isSuccess)
                {
                    MessageBox.Show("刪除成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("刪除失敗");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("資料庫刪除動作失敗" + ex.Message);
            }
        }

        // 💥新增：初始化新增模式的資料
        private void InitAddModeData()
        {
            PokemonRepositores repo = new PokemonRepositores();
            var speciesList = repo.GetPokemonSpecies();

            if (speciesList != null && speciesList.Count > 0)
            {
                // 設定下拉選單的資料來源
                cboNo.DataSource = speciesList;

                cboNo.DisplayMember = "PokemonNo";
                cboNo.ValueMember = "PokemonNo";

                // 💥 綁定「當選單改變時」的事件
                cboNo.SelectedIndexChanged += cboNo_SelectedIndexChanged;

                // 預設觸發一次，讓第一筆資料的名稱和圖片能顯示出來
                cboNo_SelectedIndexChanged(cboNo, EventArgs.Empty);

                UpdateMove();
            }

            cboFM.SelectedIndexChanged += cboMove_SelectedIndexChanged;
            cboSM.SelectedIndexChanged += cboMove_SelectedIndexChanged;
            cboTM.SelectedIndexChanged += cboMove_SelectedIndexChanged;
            cboLM.SelectedIndexChanged += cboMove_SelectedIndexChanged;
            
        }
        private void LoadPokemonDetail(int PokemonID)
        {
            PokemonRepositores repositores = new PokemonRepositores();
            currentPokemon = repositores.SearchPokemonDetail(PokemonID);

            if (currentPokemon != null)
            {
                txtNo.Text = currentPokemon.PokemonNo;
                txtName.Text = currentPokemon.PokemonName;
                txtNickName.Text = currentPokemon.nickname;
                txtType.Text = currentPokemon.Type;
                txtLv.Text = currentPokemon.Level.ToString();
                cboGender.Text = currentPokemon.Sex;
                txtHp.Text = currentPokemon.TotalHP.ToString();
                txtAtk.Text = currentPokemon.TotalAtk.ToString();
                txtDef.Text = currentPokemon.TotalDef.ToString();
                txtSp.Text = currentPokemon.TotalSp.ToString();
                txtVel.Text = currentPokemon.TotalVel.ToString();

                txtFirst.Text = currentPokemon.firstMove;
                txtSecond.Text = currentPokemon.secondMove;
                txtThird.Text = currentPokemon.thirdMove;
                txtFouth.Text = currentPokemon.fourthMove;

                // 從外部資料夾撈資料
                // 💥 1. 取得程式執行目錄下的 PokemonSprites 資料夾路徑
                string folderPath = Path.Combine(Application.StartupPath, "PokemonSprites");

                // 💥 2. 組合出這隻寶可夢圖片的完整路徑 (例如: C:\...\bin\Debug\PokemonSprites\006.gif)
                string filePath = Path.Combine(folderPath, $"{txtNo.Text}.gif");

                // 💥 3. 檢查這個檔案到底存不存在，避免程式崩潰
                if (File.Exists(filePath))
                {
                    // 如果存在，直接從硬碟檔案載入圖片！
                    pictureBoxPokemon.Image = Image.FromFile(filePath);
                    pictureBoxPokemon.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    // 如果圖片不存在（例如你還沒抓到這隻），可以給一張預設的問號圖
                    pictureBoxPokemon.Image = null; // 或者 Properties.Resources.DefaultImg;
                }
            }
        }
        private void ApplyModeSettings()
        {
            if (currentMode == FormMode.ViewOnly)
            {
                //  搜尋模式：把「編輯、刪除、存檔」等按鈕藏起來，或 Disable
                btnEdit.Visible = false;
                btnSave.Visible = false;
                btnDel.Visible = false;
                cboNo.Visible = false;
                cboHP.Visible = false;
                cboAtk.Visible = false;
                cboDef.Visible = false;
                cboSp.Visible = false;
                cboVel.Visible = false;

                // 把所有輸入框鎖定 (ReadOnly)，不讓使用者打字
                SetTextBoxReadOnly(true);

                this.Text = "寶可夢詳細資訊 (檢視)";
            }
            else if (currentMode == FormMode.Edit)
            {
                //  編輯模式：把功能按鈕顯示出來
                btnEdit.Visible = true;
                btnSave.Visible = false;
                btnDel.Visible = true;
                cboNo.Visible = false;
                cboHP.Visible = false;
                cboAtk.Visible = false;
                cboDef.Visible = false;
                cboSp.Visible = false;
                cboVel.Visible = false;

                if (currentPokemon != null)
                {
                    // 用 Text 去找下拉選單裡對應的字
                    cboHP.Text = currentPokemon.hpIV.ToString();
                    cboAtk.Text = currentPokemon.atkIV.ToString();
                    cboDef.Text = currentPokemon.defIV.ToString();
                    cboSp.Text = currentPokemon.spIV.ToString();
                    cboVel.Text = currentPokemon.velIV.ToString();
                }
                SetTextBoxReadOnly(true);
                this.Text = "寶可夢詳細資訊 (管理)";
            }
            else if (currentMode == FormMode.ADD)
            {
                btnEdit.Visible = false;
                btnSave.Visible = true;
                //btnSave.Text = "確認新增"; // 按鈕字樣順便改掉
                btnDel.Visible = false;
                cboNo.Visible = true;
                cboHP.Visible = true;
                cboAtk.Visible = true;
                cboDef.Visible = true;
                cboSp.Visible = true;
                cboVel.Visible = true;

                // 預設抓取combobox內中第一筆資料
                cboHP.SelectedIndex = 0;
                cboAtk.SelectedIndex = 0;
                cboDef.SelectedIndex = 0;
                cboSp.SelectedIndex = 0;
                cboVel.SelectedIndex = 0;

                txtLv.Text = "1"; // 預設等級為1

                SetTextBoxReadOnly(false);
                this.Text = "寶可夢詳細資訊 (新增)";
            }
        }

        private void SetTextBoxReadOnly(bool isReadOnly)
        {
            txtNickName.ReadOnly = isReadOnly;
            txtLv.ReadOnly = isReadOnly;
            txtHp.ReadOnly = isReadOnly;
            txtAtk.ReadOnly = isReadOnly;
            txtDef.ReadOnly = isReadOnly;
            txtSp.ReadOnly = isReadOnly;
            txtVel.ReadOnly = isReadOnly;
 
            txtFirst.Visible = isReadOnly;
            txtSecond.Visible = isReadOnly;
            txtThird.Visible = isReadOnly;
            txtFouth.Visible = isReadOnly;

            cboGender.Enabled = !isReadOnly;
            cboFM.Visible = !isReadOnly;
            cboSM.Visible = !isReadOnly;
            cboTM.Visible = !isReadOnly;
            cboLM.Visible = !isReadOnly;
        }

        // 💥 新增：當下拉選單選中不同寶可夢時觸發
        private void cboNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 取得當前 cboNo 選中的那一筆完整資料
            if (cboNo.SelectedItem is PokemonSpeciesModel selectedSpecies)
            {
                // 1. 自動填入名稱 (圖2的 Name 欄位)
                txtName.Text = selectedSpecies.Name;
                txtType.Text = selectedSpecies.Type;

                // 2. 自動載入對應的 GIF 圖片
                string folderPath = Path.Combine(Application.StartupPath, "PokemonSprites");
                string filePath = Path.Combine(folderPath, $"{selectedSpecies.PokemonNo}.gif");

                if (File.Exists(filePath))
                {
                    pictureBoxPokemon.Image = Image.FromFile(filePath);
                    pictureBoxPokemon.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    pictureBoxPokemon.Image = null; // 找不到圖就清空
                }
            }
            UpdateMove();
        }

        private void UpdateMove(string manuNo = null)
        {
            // 取得選中的寶可夢編號 (使用 SelectedValue 比較穩)
            string pNo = !string.IsNullOrEmpty(manuNo) ? manuNo : cboNo.SelectedValue?.ToString();

            // 防呆：如果等級沒填，預設為 1
            int lv = 1;
            int.TryParse(txtLv.Text, out lv);

            if(!string.IsNullOrEmpty(pNo))
            {
                MoveRepositores moveRepositores = new MoveRepositores();
                var moveList = moveRepositores.GetAllMoves(pNo, lv);

                // 重新初始化原始清單
                AllAvailableMove = new List<MoveDTOs> { new MoveDTOs { MoveID = 0, MoveCName = "—" } };
                if (moveList!= null) AllAvailableMove.AddRange(moveList);

                // 執行第一次的動態分配
                RefreshAllMoveComboBoxes();  
            }
        }

        private void cboMove_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = sender as ComboBox;
            if (cbo == null || cbo.SelectedValue == null) return;

            // 更新對應的 TextBox 文字
            if (cbo.SelectedItem is MoveDTOs selectedMove)
            {
                string displayText = selectedMove.MoveID == 0 ? "" : selectedMove.MoveCName;
                // 根據 sender 對應到正確的 txtBox
                if (cbo == cboFM) txtFirst.Text = selectedMove.MoveCName;
                else if (cbo == cboSM) txtSecond.Text = selectedMove.MoveCName;
                else if (cbo == cboTM) txtThird.Text = selectedMove.MoveCName;
                else if (cbo == cboLM) txtFouth.Text = selectedMove.MoveCName;
            }

            RefreshAllMoveComboBoxes();
        }

        private void txtLv_TextChanged(object sender, EventArgs e)
        {
            if(currentMode == FormMode.ADD)
            {
                UpdateMove();
            }
            else if(currentMode == FormMode.Edit)
            {
                UpdateMove(txtNo.Text);
            } 
        }

        private void RefreshAllMoveComboBoxes()
        {
            ComboBox[] comboBoxes = new ComboBox[] { cboFM, cboSM, cboTM, cboLM };

            //// 先記錄這四個選單目前「已經選了什麼 ID」
            //// 注意：如果沒選或是選到 0 (空白)，就不計入已選清單
            //var selectedMoveIDs = comboBoxes
            //    .Select(c => c.SelectedValue != null ? (int)c.SelectedValue:0)
            //    .ToList();

            //for(int i=0; i<comboBoxes.Length; i++)
            //{
            //    var currentCbo = comboBoxes[i];
            //    int currentSelectedID = selectedMoveIDs[i];

            //    // 計算出「這個選單可以用」的清單：
            //    // (原始清單中，沒被別人選走的招式) + (自己目前正在選的那一招)
            //    var filteredList = AllAvailableMove.Where(m => 
            //    m.MoveID == 0 ||                                    // 空白項永遠保留
            //    m.MoveID == currentSelectedID ||                    // 自己正在選的要保留，否則選單會變空白
            //    !selectedMoveIDs.Contains(m.MoveID))                // 別人沒選的才顯示
            //    .ToList();

            //    //  暫時解綁事件，避免更新 DataSource 時觸發無限迴圈
            //    currentCbo.SelectedIndexChanged -= cboMove_SelectedIndexChanged;

            //    currentCbo.DataSource = filteredList;
            //    currentCbo.DisplayMember = "MoveCName";
            //    currentCbo.ValueMember = "MoveID";
            //    currentCbo.SelectedValue = currentSelectedID; // 還原原本選中的項目

            //    currentCbo.SelectedIndexChanged += cboMove_SelectedIndexChanged;
            //}


            // 💥 優化版本：減少不必要的 DataSource 更新，降低閃爍感 
            // 1. 先抓取目前的狀態，避免在迴圈中反覆讀取控制項屬性
            var currentSelectedIDs = comboBoxes
                .Select(c => (c.SelectedValue is int id) ? id : 0)
                .ToArray();

            // 2. 凍結畫面重繪，減少閃爍
            this.SuspendLayout();

            try
            {
                for (int i = 0; i < comboBoxes.Length; i++)
                {
                    var currentCbo = comboBoxes[i];
                    int mySelectedID = currentSelectedIDs[i];

                    // 3. 計算該 ComboBox 應有的清單
                    var filteredList = AllAvailableMove.Where(m =>
                        m.MoveID == 0 ||
                        m.MoveID == mySelectedID ||
                        !currentSelectedIDs.Contains(m.MoveID))
                        .ToList();

                    // 4. 事件保護：徹底斷開事件
                    currentCbo.SelectedIndexChanged -= cboMove_SelectedIndexChanged;

                    // 5. 關鍵：只有當清單數量或內容真的有變時才重新指派 DataSource
                    // 這樣可以大幅減少「填入第二招時第一招暫時消失」的視覺感
                    if (currentCbo.DataSource == null || ((List<MoveDTOs>)currentCbo.DataSource).Count != filteredList.Count)
                    {
                        currentCbo.DataSource = filteredList;
                        currentCbo.DisplayMember = "MoveCName";
                        currentCbo.ValueMember = "MoveID";
                    }

                    // 6. 強制還原 ID
                    currentCbo.SelectedValue = mySelectedID;

                    // 7. 重新掛載事件
                    currentCbo.SelectedIndexChanged += cboMove_SelectedIndexChanged;
                }
            }
            finally
            {
                // 8. 恢復畫面重繪
                this.ResumeLayout(false);
            }
        }
    }
}
