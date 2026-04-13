namespace 訓練家管理系統.MyControls
{
    partial class ucUserInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblTID = new System.Windows.Forms.Label();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBD = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblBN = new System.Windows.Forms.Label();
            this.txtTName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtBN = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1669, 157);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("新細明體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(607, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "您的基本資料";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 804);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1669, 100);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancel.Location = new System.Drawing.Point(883, 28);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 40);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(722, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEdit.Location = new System.Drawing.Point(360, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 40);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "編輯";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblTID
            // 
            this.lblTID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTID.Location = new System.Drawing.Point(144, 228);
            this.lblTID.Name = "lblTID";
            this.lblTID.Size = new System.Drawing.Size(109, 53);
            this.lblTID.TabIndex = 2;
            this.lblTID.Text = "TID";
            this.lblTID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTID
            // 
            this.txtTID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTID.Location = new System.Drawing.Point(292, 242);
            this.txtTID.Name = "txtTID";
            this.txtTID.ReadOnly = true;
            this.txtTID.Size = new System.Drawing.Size(143, 29);
            this.txtTID.TabIndex = 3;
            this.txtTID.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.Location = new System.Drawing.Point(1065, 229);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(109, 53);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "稱號";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAccount
            // 
            this.lblAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAccount.Location = new System.Drawing.Point(145, 350);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(109, 53);
            this.lblAccount.TabIndex = 5;
            this.lblAccount.Text = "帳號";
            this.lblAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPassword.Location = new System.Drawing.Point(145, 475);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(109, 53);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "密碼";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTName
            // 
            this.lblTName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTName.Location = new System.Drawing.Point(587, 229);
            this.lblTName.Name = "lblTName";
            this.lblTName.Size = new System.Drawing.Size(109, 53);
            this.lblTName.TabIndex = 7;
            this.lblTName.Text = "姓名";
            this.lblTName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGender.Location = new System.Drawing.Point(587, 350);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(109, 53);
            this.lblGender.TabIndex = 8;
            this.lblGender.Text = "性別";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBD
            // 
            this.lblBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBD.Location = new System.Drawing.Point(587, 475);
            this.lblBD.Name = "lblBD";
            this.lblBD.Size = new System.Drawing.Size(109, 53);
            this.lblBD.TabIndex = 9;
            this.lblBD.Text = "生日";
            this.lblBD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAddress.Location = new System.Drawing.Point(145, 717);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(109, 53);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "地址";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPhone.Location = new System.Drawing.Point(587, 599);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(109, 53);
            this.lblPhone.TabIndex = 11;
            this.lblPhone.Text = "手機號碼";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBN
            // 
            this.lblBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBN.Location = new System.Drawing.Point(1065, 350);
            this.lblBN.Name = "lblBN";
            this.lblBN.Size = new System.Drawing.Size(109, 53);
            this.lblBN.TabIndex = 12;
            this.lblBN.Text = "徽章數量";
            this.lblBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTName
            // 
            this.txtTName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTName.Location = new System.Drawing.Point(756, 243);
            this.txtTName.Name = "txtTName";
            this.txtTName.ReadOnly = true;
            this.txtTName.Size = new System.Drawing.Size(143, 29);
            this.txtTName.TabIndex = 13;
            this.txtTName.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // txtTitle
            // 
            this.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitle.Location = new System.Drawing.Point(1238, 243);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(192, 29);
            this.txtTitle.TabIndex = 14;
            this.txtTitle.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // txtAccount
            // 
            this.txtAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAccount.Location = new System.Drawing.Point(293, 364);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(166, 29);
            this.txtAccount.TabIndex = 15;
            this.txtAccount.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPassword.Location = new System.Drawing.Point(293, 489);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(166, 29);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // txtGender
            // 
            this.txtGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGender.Location = new System.Drawing.Point(756, 364);
            this.txtGender.Name = "txtGender";
            this.txtGender.ReadOnly = true;
            this.txtGender.Size = new System.Drawing.Size(86, 29);
            this.txtGender.TabIndex = 17;
            this.txtGender.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // txtBN
            // 
            this.txtBN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBN.Location = new System.Drawing.Point(1238, 364);
            this.txtBN.Name = "txtBN";
            this.txtBN.ReadOnly = true;
            this.txtBN.Size = new System.Drawing.Size(66, 29);
            this.txtBN.TabIndex = 18;
            this.txtBN.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // txtBD
            // 
            this.txtBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBD.Location = new System.Drawing.Point(756, 489);
            this.txtBD.Name = "txtBD";
            this.txtBD.ReadOnly = true;
            this.txtBD.Size = new System.Drawing.Size(143, 29);
            this.txtBD.TabIndex = 19;
            this.txtBD.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhone.Location = new System.Drawing.Point(756, 613);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(215, 29);
            this.txtPhone.TabIndex = 20;
            this.txtPhone.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Location = new System.Drawing.Point(293, 731);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(678, 29);
            this.txtAddress.TabIndex = 21;
            this.txtAddress.Enter += new System.EventHandler(this.DisableCaret_Enter);
            // 
            // cboGender
            // 
            this.cboGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "♂",
            "♀",
            "不方便透漏"});
            this.cboGender.Location = new System.Drawing.Point(756, 364);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(86, 26);
            this.cboGender.TabIndex = 22;
            this.cboGender.Visible = false;
            // 
            // dtpBD
            // 
            this.dtpBD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpBD.Location = new System.Drawing.Point(756, 489);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(143, 29);
            this.dtpBD.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1669, 10);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1669, 10);
            this.panel4.TabIndex = 3;
            // 
            // ucUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpBD);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.txtBN);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtTName);
            this.Controls.Add(this.lblBN);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBD);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblTName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTID);
            this.Controls.Add(this.lblTID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ucUserInfo";
            this.Size = new System.Drawing.Size(1669, 904);
            this.Load += new System.EventHandler(this.ucUserInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label lblTID;
        private System.Windows.Forms.TextBox txtTID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblBD;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblBN;
        private System.Windows.Forms.TextBox txtTName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtBN;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
