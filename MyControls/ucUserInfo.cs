using 訓練家管理系統.Models;
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
    public partial class ucUserInfo : UserControl
    {
        public ucUserInfo()
        {
            InitializeComponent();
        }

        private void ucUserInfo_Load(object sender, EventArgs e)
        {
            LoadData();

            btnSave.Visible = false;
            btnCancel.Visible = false;
            dtpBD.Visible = false;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            LockGrid(false);

            cboGender.Visible = true;
            txtGender.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;

            cboGender.Text = txtGender.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel userModel = new UserModel
                {
                    TrainerName = txtTName.Text, Title=txtTitle.Text,
                    TrainerAccount = txtAccount.Text, TrainerPassword = txtPassword.Text,
                    BadgeNumber = Convert.ToInt32(txtBN.Text), Gender = cboGender.Text,
                    Birthdate = dtpBD.Value.ToString("yyyy-MM-dd"), PhoneNumber = txtPhone.Text, Address = txtAddress.Text,
                    UpdatedBy = UserSession.currentUser.TrainerName, ID = UserSession.currentUser.ID,
                    TID = UserSession.currentUser.TID
                };

                UserRepositores repo = new UserRepositores();
                bool isUpdated = repo.UpdateUserInfo(userModel);

                if(isUpdated)
                {
                    MessageBox.Show("儲存成功");
                    LockGrid(true);
                    UserSession.currentUser = userModel;
                    cboGender.Visible = false;
                    txtGender.Visible = true;
                    btnSave.Visible = false;
                    btnCancel.Visible = false;

                    LoadData();
                }
            }catch (Exception ex)
            {
                MessageBox.Show("存取異常" + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LockGrid(true);
            cboGender.Visible = false;
            txtGender.Visible = true;
            btnSave.Visible = false;
            btnCancel.Visible = false;
        }

        private void LoadData()
        {
            if(UserSession.currentUser!=null)
            {
                txtTID.Text = UserSession.currentUser.TID;
                txtTName.Text = UserSession.currentUser.TrainerName;
                txtAccount.Text = UserSession.currentUser.TrainerAccount;
                txtPassword.Text = UserSession.currentUser.TrainerPassword;
                txtTitle.Text = UserSession.currentUser.Title;
                txtGender.Text = UserSession.currentUser.Gender;
                txtBD.Text = UserSession.currentUser.Birthdate??"";
                txtBN.Text = UserSession.currentUser.BadgeNumber.ToString();
                txtPhone.Text = UserSession.currentUser.PhoneNumber;
                txtAddress.Text = UserSession.currentUser.Address;
            }
        }

        private void LockGrid(bool isLock)
        {
            List<TextBox> texts = new List<TextBox>
            {
                txtTName,txtTitle,txtAccount,txtPassword,txtGender,txtBN,txtBD,
                txtPhone,txtAddress
            };

            foreach (TextBox text in texts)
            {
                text.ReadOnly = isLock;
                text.TabStop = !isLock;
            }

            dtpBD.Visible = !isLock;
        }

        private void DisableCaret_Enter(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null)
            {
                // 只有當 TextBox 是唯讀時，才把焦點移走
                if (tb.ReadOnly == true)
                {
                    this.ActiveControl = null;
                }
                // 如果 ReadOnly 是 false (代表現在是編輯模式)，就不會執行 ActiveControl = null
                // 游標就會乖乖出現讓使用者輸入了！
            }
        }

    }
}
