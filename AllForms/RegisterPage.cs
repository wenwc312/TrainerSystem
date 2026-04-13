using 訓練家管理系統.DTOs;
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

namespace 訓練家管理系統.AllForms
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
            txtAccount.GotFocus += txtAccount_GotFocus;
            txtAccount.LostFocus += txtAccount_LostFocus;
            txtPassword.GotFocus += txtPassword_GotFocus;
            txtPassword.LostFocus += txtPassword_LostFocus;
            txtPasswordCheck.GotFocus += txtPasswordCheck_GotFocus;
            txtPasswordCheck.LostFocus += txtPasswordCheck_LostFocus;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string account = txtAccount.Text.Trim();
            string password = txtPassword.Text.Trim();
            string pwdcheck = txtPasswordCheck.Text.Trim();

            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(account) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(pwdcheck))
            {
                MessageBox.Show("姓名、帳號及密碼所有欄位都不能空白");
                return;
            }

            if(password.Length<8 || password.Length > 16)
            {
                MessageBox.Show("密碼長度不符請重新輸入");
                return;
            }

            if (password != pwdcheck)
            {
                MessageBox.Show("密碼兩次輸入不一致請重新輸入");
                return;
            }

            UserRepositores repo = new UserRepositores();
            if (repo.checkAccountExisted(account))
            {
                MessageBox.Show("此帳號已被使用，請重新輸入");
                return;
            }

            try
            {
                string TID = repo.GetNextTID();
                RegisterDTOs registerDT = new RegisterDTOs
                {
                    TID = TID,
                    TrainerName = name,
                    TrainerAccount = account,
                    TrainerPassword = password,
                    Role = 1
                };

                if (repo.Register(registerDT))
                {
                    MessageBox.Show("註冊成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("註冊失敗");
                    return;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("資料庫無法新增"+ex.Message);
            }
        }

        private void txtAccount_GotFocus(object sender, EventArgs e)
        {
            lblNote1.Text = "";
            lblNote1.Visible = false;
        }
        private void txtAccount_LostFocus(object sender, EventArgs e)
        {
            string account = txtAccount.Text.Trim();
            if (string.IsNullOrEmpty(account)) return;

            try
            {
                UserRepositores repo = new UserRepositores();
                bool isExist = repo.checkAccountExisted(account);
                if (isExist)
                {
                    lblNote1.Visible = true;
                    lblNote1.Text = "此帳號已被使用";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("帳號檢查失敗"+ex.Message);
            }
        }

        private void txtPassword_GotFocus(object sender, EventArgs e)
        {
            lblNote2.Text = "◎密碼有區分大小寫，長度為8~16個字";
            lblNote2.Visible = true;
        }
        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
            lblNote2.Visible = false;
            string pwd = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(pwd)) return;

            if (pwd.Length < 8)
            {
                lblNote2.Text = "密碼長度不足";
                lblNote2.Visible = true;
            }else if(pwd.Length > 16)
            {
                lblNote2.Text = "密碼長度過長";
                lblNote2.Visible = true;
            }
        }
        private void txtPasswordCheck_GotFocus(Object sender, EventArgs e)
        {
            lblNote3.Text = "請注意大小寫是否一致";
            lblNote3.Visible = true;
        }
        private void txtPasswordCheck_LostFocus(Object sender, EventArgs e)
        {
            lblNote3.Visible = false;
            if (txtPasswordCheck.Text != txtPassword.Text)
            {
                lblNote3.Text = "密碼不一致請重新輸入";
                lblNote3.Visible = true;
            }
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            if(txtPassword.UseSystemPasswordChar)
            {
                btnShow1.Text = "顯示";
            }
            else
            {
                btnShow1.Text = "隱藏";
            }
        }

        private void btnShow2_Click(object sender, EventArgs e)
        {
            txtPasswordCheck.UseSystemPasswordChar = !txtPasswordCheck.UseSystemPasswordChar;
            if (txtPasswordCheck.UseSystemPasswordChar)
            {
                btnShow2.Text = "顯示";
            }
            else
            {
                btnShow2.Text = "隱藏";
            }
        }
    }
}
