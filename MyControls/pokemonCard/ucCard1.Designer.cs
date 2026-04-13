namespace 訓練家管理系統.MyControls.pokemonCard
{
    partial class ucCard1
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
            this.lblNo = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.labLv = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtLv = new System.Windows.Forms.TextBox();
            this.pictureBoxPokemon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNo
            // 
            this.lblNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNo.Location = new System.Drawing.Point(120, 18);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(67, 46);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "No.1";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPName
            // 
            this.txtPName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPName.Location = new System.Drawing.Point(202, 29);
            this.txtPName.Name = "txtPName";
            this.txtPName.ReadOnly = true;
            this.txtPName.Size = new System.Drawing.Size(100, 29);
            this.txtPName.TabIndex = 1;
            this.txtPName.TabStop = false;
            this.txtPName.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // lblSex
            // 
            this.lblSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSex.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSex.Location = new System.Drawing.Point(16, 104);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(67, 46);
            this.lblSex.TabIndex = 3;
            this.lblSex.Text = "性別";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labLv
            // 
            this.labLv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labLv.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labLv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labLv.Location = new System.Drawing.Point(179, 104);
            this.labLv.Name = "labLv";
            this.labLv.Size = new System.Drawing.Size(67, 46);
            this.labLv.TabIndex = 4;
            this.labLv.Text = "等級";
            this.labLv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSex
            // 
            this.txtSex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSex.Location = new System.Drawing.Point(98, 115);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(52, 29);
            this.txtSex.TabIndex = 5;
            this.txtSex.TabStop = false;
            this.txtSex.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // txtLv
            // 
            this.txtLv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLv.Location = new System.Drawing.Point(267, 115);
            this.txtLv.Name = "txtLv";
            this.txtLv.ReadOnly = true;
            this.txtLv.Size = new System.Drawing.Size(59, 29);
            this.txtLv.TabIndex = 6;
            this.txtLv.TabStop = false;
            this.txtLv.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // pictureBoxPokemon
            // 
            this.pictureBoxPokemon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxPokemon.BackColor = System.Drawing.Color.White;
            this.pictureBoxPokemon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxPokemon.Location = new System.Drawing.Point(16, 18);
            this.pictureBoxPokemon.Name = "pictureBoxPokemon";
            this.pictureBoxPokemon.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxPokemon.TabIndex = 2;
            this.pictureBoxPokemon.TabStop = false;
            // 
            // ucCard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txtLv);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.labLv);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.pictureBoxPokemon);
            this.Controls.Add(this.txtPName);
            this.Controls.Add(this.lblNo);
            this.Name = "ucCard1";
            this.Size = new System.Drawing.Size(343, 175);
            this.Load += new System.EventHandler(this.ucCard1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.PictureBox pictureBoxPokemon;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label labLv;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtLv;
    }
}
