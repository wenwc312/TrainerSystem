namespace 訓練家管理系統.MyControls.pokemonCard
{
    partial class ucCard2
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtpNo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPokemon.BackColor = System.Drawing.Color.White;
            this.pictureBoxPokemon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPokemon.Location = new System.Drawing.Point(42, 23);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxPokemon.TabIndex = 0;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Wheat;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(183, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "名稱";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpName
            // 
            this.txtpName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpName.Location = new System.Drawing.Point(272, 80);
            this.txtpName.Name = "txtpName";
            this.txtpName.ReadOnly = true;
            this.txtpName.Size = new System.Drawing.Size(115, 29);
            this.txtpName.TabIndex = 2;
            this.txtpName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpName.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(183, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "暱稱";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNickname
            // 
            this.txtNickname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNickname.Location = new System.Drawing.Point(272, 144);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.ReadOnly = true;
            this.txtNickname.Size = new System.Drawing.Size(115, 29);
            this.txtNickname.TabIndex = 4;
            this.txtNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNickname.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(42, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "性別";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtgender
            // 
            this.txtgender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtgender.Location = new System.Drawing.Point(42, 188);
            this.txtgender.Name = "txtgender";
            this.txtgender.ReadOnly = true;
            this.txtgender.Size = new System.Drawing.Size(59, 29);
            this.txtgender.TabIndex = 6;
            this.txtgender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtgender.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Wheat;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(183, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "等級";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLv
            // 
            this.txtLv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLv.Location = new System.Drawing.Point(272, 201);
            this.txtLv.Name = "txtLv";
            this.txtLv.ReadOnly = true;
            this.txtLv.Size = new System.Drawing.Size(100, 29);
            this.txtLv.TabIndex = 8;
            this.txtLv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLv.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Wheat;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(183, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "編號";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtpNo
            // 
            this.txtpNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtpNo.Location = new System.Drawing.Point(272, 25);
            this.txtpNo.Name = "txtpNo";
            this.txtpNo.ReadOnly = true;
            this.txtpNo.Size = new System.Drawing.Size(115, 29);
            this.txtpNo.TabIndex = 10;
            this.txtpNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtpNo.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // ucCard2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.txtpNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNickname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Name = "ucCard2";
            this.Size = new System.Drawing.Size(446, 256);
            this.Load += new System.EventHandler(this.ucCard2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtpNo;
    }
}
