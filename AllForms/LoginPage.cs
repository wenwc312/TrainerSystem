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
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
            object imageObj = Properties.Resources.pokemon_ball_3Dart;
            pictureBoxIcon.Image = (Image)imageObj;
            pictureBoxIcon.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxIcon2.Image = (Image)imageObj;
            pictureBoxIcon2.SizeMode = PictureBoxSizeMode.Zoom;

            object imageLogo = Properties.Resources.pokemonlogo;
            pictureBoxlogo.Image = (Image)imageLogo;
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.Zoom;

        }
        private void txtAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(13))
            {
                this.SelectNextControl(this.ActiveControl,true, true, true, false);
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(13))
            {
                btnLogin.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var loginParam = new LoginDTO
            {
                Account = txtAccount.Text,
                Password = txtPassword.Text
            };

            UserRepositores repo = new UserRepositores();
            UserModel loginuser = repo.Login(loginParam);

            if (loginuser != null)
            {
                //將登入者資訊存入UserSession
                UserSession.currentUser = loginuser;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }else
            {
                MessageBox.Show("登入失敗");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterPage register = new RegisterPage();
            register.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
            if (txtPassword.UseSystemPasswordChar)
            {
                btnShow.Text = "顯示";
            }
            else
            {
                btnShow.Text = "隱藏";
            }
        }
    }
}
