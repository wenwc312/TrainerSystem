namespace 訓練家管理系統.AllForms
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnLeave = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.PokemonInfo = new System.Windows.Forms.Button();
            this.btnSearchTrainer = new System.Windows.Forms.Button();
            this.lblTID = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Controls.Add(this.btnLeave);
            this.panel1.Controls.Add(this.btnUserInfo);
            this.panel1.Controls.Add(this.PokemonInfo);
            this.panel1.Controls.Add(this.btnSearchTrainer);
            this.panel1.Controls.Add(this.lblTID);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 944);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 944);
            this.panel3.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogout.Location = new System.Drawing.Point(117, 812);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(72, 38);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "登出";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnLeave
            // 
            this.btnLeave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeave.Location = new System.Drawing.Point(23, 812);
            this.btnLeave.Name = "btnLeave";
            this.btnLeave.Size = new System.Drawing.Size(75, 38);
            this.btnLeave.TabIndex = 5;
            this.btnLeave.Text = "離開";
            this.btnLeave.UseVisualStyleBackColor = true;
            this.btnLeave.Click += new System.EventHandler(this.btnLeave_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUserInfo.Location = new System.Drawing.Point(33, 663);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(147, 48);
            this.btnUserInfo.TabIndex = 4;
            this.btnUserInfo.Text = "訓練家基本資料";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // PokemonInfo
            // 
            this.PokemonInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PokemonInfo.Location = new System.Drawing.Point(33, 336);
            this.PokemonInfo.Name = "PokemonInfo";
            this.PokemonInfo.Size = new System.Drawing.Size(147, 47);
            this.PokemonInfo.TabIndex = 3;
            this.PokemonInfo.Text = "隨身寶可夢資訊";
            this.PokemonInfo.UseVisualStyleBackColor = true;
            this.PokemonInfo.Click += new System.EventHandler(this.PokemonInfo_Click);
            // 
            // btnSearchTrainer
            // 
            this.btnSearchTrainer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearchTrainer.Location = new System.Drawing.Point(33, 234);
            this.btnSearchTrainer.Name = "btnSearchTrainer";
            this.btnSearchTrainer.Size = new System.Drawing.Size(147, 47);
            this.btnSearchTrainer.TabIndex = 2;
            this.btnSearchTrainer.Text = "訓練家搜尋";
            this.btnSearchTrainer.UseVisualStyleBackColor = true;
            this.btnSearchTrainer.Click += new System.EventHandler(this.btnSearchTrainer_Click);
            // 
            // lblTID
            // 
            this.lblTID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTID.BackColor = System.Drawing.Color.Aqua;
            this.lblTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTID.Location = new System.Drawing.Point(12, 140);
            this.lblTID.Name = "lblTID";
            this.lblTID.Size = new System.Drawing.Size(190, 29);
            this.lblTID.TabIndex = 1;
            this.lblTID.Text = "TID:";
            this.lblTID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoEllipsis = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Aqua;
            this.lblWelcome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWelcome.Font = new System.Drawing.Font("新細明體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 29);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(190, 79);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "XXX!歡迎!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(229, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1669, 944);
            this.pnlContent.TabIndex = 1;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 944);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTID;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnLeave;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button PokemonInfo;
        private System.Windows.Forms.Button btnSearchTrainer;
        private System.Windows.Forms.Panel panel3;
    }
}