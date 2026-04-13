using 訓練家管理系統.AllForms;
using 訓練家管理系統.DTOs;
using 訓練家管理系統.Models;
using 訓練家管理系統.MyControls.pokemonCard;
using 訓練家管理系統.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 訓練家管理系統.MyControls
{
    
    public partial class ucSearchTrainer : UserControl
    {
        private List<UserModel> userList = new List<UserModel>();
        private int selectedTrainerID = 0;
        public ucSearchTrainer()
        {
            InitializeComponent();
        }
        private void ucSearchTrainer_Load(object sender, EventArgs e)
        {
            
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            ExecuteSearch();
        }

        public void ExecuteSearch(TrainerSearchDTOs extrenalArgs = null)
        {
            var searchArgs = new TrainerSearchDTOs
            {
                TrainerName = txtTName.Text.Trim(),
                TID = txtTID.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            };

            if (searchArgs.isEmpty)
            {
                MessageBox.Show("請至少輸入一個搜尋條件!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserRepositores repo = new UserRepositores();
            userList = repo.SearchTrainer(searchArgs);
            if (userList == null)
            {
                MessageBox.Show("查無此資料");
                return;
            }

            dgvResult.DataSource = userList.Select(u => new
            {
                登錄ID = u.TID,
                訓練家姓名 = u.TrainerName,
                性別 = u.Gender,
                手機號碼 = u.PhoneNumber,
                徽章數量 = u.BadgeNumber,
                稱號 = u.Title
            }).ToList();

            if (userList!=null && userList.Count>0)
            {
                // 取得搜尋結果第一個人的資料庫 ID
                int firstTrainerId = userList[0].ID;
                LoadTrainerPokemons(firstTrainerId);
  
            }
            else
            {
                MessageBox.Show("資料載入錯誤");
                dgvResult.DataSource = null;
            } 
        }

        private void LoadTrainerPokemons(int selectedTrainerID)
        {
            //  清空舊的卡片
            tableLayoutPanelPokemon.Controls.Clear();

            // 先隱藏
            tableLayoutPanelPokemon.Visible = false;
            lbltitle.Visible = false;

            PokemonRepositores repo = new PokemonRepositores();
            var pokemonList = repo.SearchPokemonInfo(selectedTrainerID);

            // 檢查回傳資料數量
            //MessageBox.Show($"[Debug] 資料庫回傳的寶可夢數量是：{pokemonList.Count}");

            if (pokemonList == null || pokemonList.Count == 0) return;

            int count = 0;
            foreach(var pokemon in pokemonList.Take(6))
            {
                ucCard1 card = new ucCard1();

                card.SetData(pokemon.PokemonName,pokemon.Sex,pokemon.Level,pokemon.PokemonNo,count);

                // 綁定點擊卡片跳出詳細視窗 (上一題提到的功能)
                //ucCard.Click += (s, args) => {
                //    frmPokemonDetail detailForm = new frmPokemonDetail(p.PokemonID);
                //    detailForm.ShowDialog();
                //};

                card.Anchor = AnchorStyles.None;

                int row = count / 3;
                int col = count % 3;

                tableLayoutPanelPokemon.Controls.Add(card, col, row);
                count++;

                // 💥 關鍵 3：綁定點擊事件！
                card.Click += (s, args) =>
                {
                    // 這裡寫點擊卡片後你要做的事情！

                    // 例如：顯示詳細視窗，把這隻寶可夢的 No 傳過去
                    PokemonDetail detail = new PokemonDetail(pokemon.ID,PokemonDetail.FormMode.ViewOnly);
                    detail.ShowDialog();  // 用 ShowDialog 鎖定視窗，體驗比較好
                };

                // 檢查執行次數
                //Console.WriteLine("產生一張卡片");
            }

            tableLayoutPanelPokemon.Visible = true;
            lbltitle.Visible = true;
        }

        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && userList != null)
            {
                // 透過 RowIndex 找到原始 list 中的完整物件
                var selectedTrainer = userList[e.RowIndex];

                LoadTrainerPokemons(selectedTrainer.ID);
                
            }
        }
    }
}
