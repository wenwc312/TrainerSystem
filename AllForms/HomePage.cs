using 訓練家管理系統.Models;
using 訓練家管理系統.MyControls;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            ucWelcome ucWelcome = new ucWelcome();
            ShowControl(ucWelcome);
        }
        private void HomePage_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"哈囉!{UserSession.currentUser.TrainerName}!";
            lblTID.Text = $"TID:{UserSession.currentUser.TID}";
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確認關閉嗎?","離開確認",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("確認登出嗎?","登出確認",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            ucUserInfo ucUser = new ucUserInfo();
            ShowControl(ucUser);
        }
        private void btnSearchTrainer_Click(object sender, EventArgs e)
        {
            ucSearchTrainer searchTrainer = new ucSearchTrainer();
            ShowControl(searchTrainer);
        }
        private void PokemonInfo_Click(object sender, EventArgs e)
        {
            ucPokemonInfo ucPokemonInfo = new ucPokemonInfo();
            ShowControl(ucPokemonInfo);
        }
        private void ShowControl(UserControl uc)
        {
            pnlContent.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(uc);
        }

    }
}
