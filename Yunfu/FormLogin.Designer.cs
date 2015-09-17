namespace Yunfu
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbUsername = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.linklblPsd = new System.Windows.Forms.LinkLabel();
            this.txtPsd = new System.Windows.Forms.TextBox();
            this.txtRePsd = new System.Windows.Forms.TextBox();
            this.panelPsd = new System.Windows.Forms.Panel();
            this.lblPsdMsg = new System.Windows.Forms.Label();
            this.linkLblLogin = new System.Windows.Forms.LinkLabel();
            this.btmPsd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPsd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(144, 154);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(96, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "登   录";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbUsername
            // 
            this.cmbUsername.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsername.FormattingEnabled = true;
            this.cmbUsername.Location = new System.Drawing.Point(156, 74);
            this.cmbUsername.Name = "cmbUsername";
            this.cmbUsername.Size = new System.Drawing.Size(155, 20);
            this.cmbUsername.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "姓 名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "密 码：";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(156, 118);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(155, 21);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(169, 195);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(41, 12);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Text = "lblMsg";
            // 
            // linklblPsd
            // 
            this.linklblPsd.AutoSize = true;
            this.linklblPsd.Location = new System.Drawing.Point(325, 264);
            this.linklblPsd.Name = "linklblPsd";
            this.linklblPsd.Size = new System.Drawing.Size(53, 12);
            this.linklblPsd.TabIndex = 6;
            this.linklblPsd.TabStop = true;
            this.linklblPsd.Text = "修改密码";
            this.linklblPsd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblPsd_LinkClicked);
            // 
            // txtPsd
            // 
            this.txtPsd.Location = new System.Drawing.Point(88, 11);
            this.txtPsd.Name = "txtPsd";
            this.txtPsd.PasswordChar = '*';
            this.txtPsd.Size = new System.Drawing.Size(155, 21);
            this.txtPsd.TabIndex = 7;
            // 
            // txtRePsd
            // 
            this.txtRePsd.Location = new System.Drawing.Point(88, 41);
            this.txtRePsd.Name = "txtRePsd";
            this.txtRePsd.PasswordChar = '*';
            this.txtRePsd.Size = new System.Drawing.Size(155, 21);
            this.txtRePsd.TabIndex = 8;
            // 
            // panelPsd
            // 
            this.panelPsd.Controls.Add(this.lblPsdMsg);
            this.panelPsd.Controls.Add(this.linkLblLogin);
            this.panelPsd.Controls.Add(this.btmPsd);
            this.panelPsd.Controls.Add(this.label4);
            this.panelPsd.Controls.Add(this.txtPsd);
            this.panelPsd.Controls.Add(this.txtRePsd);
            this.panelPsd.Controls.Add(this.label3);
            this.panelPsd.Location = new System.Drawing.Point(68, 145);
            this.panelPsd.Name = "panelPsd";
            this.panelPsd.Size = new System.Drawing.Size(256, 131);
            this.panelPsd.TabIndex = 9;
            this.panelPsd.Visible = false;
            // 
            // lblPsdMsg
            // 
            this.lblPsdMsg.AutoSize = true;
            this.lblPsdMsg.ForeColor = System.Drawing.Color.Red;
            this.lblPsdMsg.Location = new System.Drawing.Point(95, 110);
            this.lblPsdMsg.Name = "lblPsdMsg";
            this.lblPsdMsg.Size = new System.Drawing.Size(59, 12);
            this.lblPsdMsg.TabIndex = 13;
            this.lblPsdMsg.Text = "lblPsdMsg";
            this.lblPsdMsg.Visible = false;
            // 
            // linkLblLogin
            // 
            this.linkLblLogin.AutoSize = true;
            this.linkLblLogin.Location = new System.Drawing.Point(214, 85);
            this.linkLblLogin.Name = "linkLblLogin";
            this.linkLblLogin.Size = new System.Drawing.Size(29, 12);
            this.linkLblLogin.TabIndex = 12;
            this.linkLblLogin.TabStop = true;
            this.linkLblLogin.Text = "登录";
            this.linkLblLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblLogin_LinkClicked);
            // 
            // btmPsd
            // 
            this.btmPsd.Location = new System.Drawing.Point(97, 80);
            this.btmPsd.Name = "btmPsd";
            this.btmPsd.Size = new System.Drawing.Size(75, 23);
            this.btmPsd.TabIndex = 11;
            this.btmPsd.Text = "修改密码";
            this.btmPsd.UseVisualStyleBackColor = true;
            this.btmPsd.Click += new System.EventHandler(this.btmPsd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "确认密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "新密码：";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 285);
            this.Controls.Add(this.panelPsd);
            this.Controls.Add(this.linklblPsd);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsername);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "收银员登录";
            this.panelPsd.ResumeLayout(false);
            this.panelPsd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ComboBox cmbUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.LinkLabel linklblPsd;
        private System.Windows.Forms.TextBox txtPsd;
        private System.Windows.Forms.TextBox txtRePsd;
        private System.Windows.Forms.Panel panelPsd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmPsd;
        private System.Windows.Forms.LinkLabel linkLblLogin;
        private System.Windows.Forms.Label lblPsdMsg;
    }
}