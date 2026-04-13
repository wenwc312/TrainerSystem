namespace 訓練家管理系統.MyControls
{
    partial class ucWelcome
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
            this.lblWelcom = new System.Windows.Forms.Label();
            this.pictureBoxbackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbackground)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcom
            // 
            this.lblWelcom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcom.BackColor = System.Drawing.SystemColors.Info;
            this.lblWelcom.Font = new System.Drawing.Font("HGSoeiKakupoptai", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcom.Location = new System.Drawing.Point(295, 114);
            this.lblWelcom.Name = "lblWelcom";
            this.lblWelcom.Size = new System.Drawing.Size(1080, 132);
            this.lblWelcom.TabIndex = 0;
            this.lblWelcom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxbackground
            // 
            this.pictureBoxbackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxbackground.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxbackground.Name = "pictureBoxbackground";
            this.pictureBoxbackground.Size = new System.Drawing.Size(1669, 944);
            this.pictureBoxbackground.TabIndex = 1;
            this.pictureBoxbackground.TabStop = false;
            // 
            // ucWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblWelcom);
            this.Controls.Add(this.pictureBoxbackground);
            this.Name = "ucWelcome";
            this.Size = new System.Drawing.Size(1669, 944);
            this.Load += new System.EventHandler(this.ucWelcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxbackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWelcom;
        private System.Windows.Forms.PictureBox pictureBoxbackground;
    }
}
