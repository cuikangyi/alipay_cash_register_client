namespace Yunfu
{
    partial class FormConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.btnOK = new System.Windows.Forms.Button();
            this.cbIsVoice = new System.Windows.Forms.CheckBox();
            this.cbIsPrint = new System.Windows.Forms.CheckBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picBg = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.lstPrinter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDual = new System.Windows.Forms.CheckBox();
            this.cbUseLptPrint = new System.Windows.Forms.CheckBox();
            this.lstLpt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(170, 254);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(158, 37);
            this.btnOK.TabIndex = 6;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cbIsVoice
            // 
            this.cbIsVoice.AutoSize = true;
            this.cbIsVoice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbIsVoice.Location = new System.Drawing.Point(137, 91);
            this.cbIsVoice.Name = "cbIsVoice";
            this.cbIsVoice.Size = new System.Drawing.Size(72, 16);
            this.cbIsVoice.TabIndex = 5;
            this.cbIsVoice.Text = "开启声音";
            this.cbIsVoice.UseVisualStyleBackColor = false;
            // 
            // cbIsPrint
            // 
            this.cbIsPrint.AutoSize = true;
            this.cbIsPrint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbIsPrint.Location = new System.Drawing.Point(137, 132);
            this.cbIsPrint.Name = "cbIsPrint";
            this.cbIsPrint.Size = new System.Drawing.Size(72, 16);
            this.cbIsPrint.TabIndex = 4;
            this.cbIsPrint.Text = "开启打印";
            this.cbIsPrint.UseVisualStyleBackColor = false;
            this.cbIsPrint.CheckedChanged += new System.EventHandler(this.chbIsPrint_CheckedChanged);
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(427, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(49, 37);
            this.picClose.TabIndex = 50;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(168, 324);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(41, 12);
            this.lblMsg.TabIndex = 51;
            this.lblMsg.Text = "lblMsg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(40, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "配置              ";
            this.label3.DoubleClick += new System.EventHandler(this.label3_DoubleClick);
            // 
            // picBg
            // 
            this.picBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBg.Image = ((System.Drawing.Image)(resources.GetObject("picBg.Image")));
            this.picBg.Location = new System.Drawing.Point(0, 0);
            this.picBg.Name = "picBg";
            this.picBg.Size = new System.Drawing.Size(478, 403);
            this.picBg.TabIndex = 16;
            this.picBg.TabStop = false;
            this.picBg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBg_MouseDown);
            this.picBg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBg_MouseMove);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel1.Location = new System.Drawing.Point(12, 371);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(53, 12);
            this.linkLabel1.TabIndex = 55;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "重置设备";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabel2.Location = new System.Drawing.Point(413, 371);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(53, 12);
            this.linkLabel2.TabIndex = 56;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "打印调试";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // lstPrinter
            // 
            this.lstPrinter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstPrinter.FormattingEnabled = true;
            this.lstPrinter.Location = new System.Drawing.Point(224, 170);
            this.lstPrinter.Name = "lstPrinter";
            this.lstPrinter.Size = new System.Drawing.Size(129, 20);
            this.lstPrinter.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(137, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 57;
            this.label1.Text = "选择打印机";
            // 
            // cbDual
            // 
            this.cbDual.AutoSize = true;
            this.cbDual.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cbDual.Location = new System.Drawing.Point(224, 132);
            this.cbDual.Name = "cbDual";
            this.cbDual.Size = new System.Drawing.Size(84, 16);
            this.cbDual.TabIndex = 58;
            this.cbDual.Text = "打印两张票";
            this.cbDual.UseVisualStyleBackColor = false;
            // 
            // cbUseLptPrint
            // 
            this.cbUseLptPrint.AutoSize = true;
            this.cbUseLptPrint.Location = new System.Drawing.Point(137, 210);
            this.cbUseLptPrint.Name = "cbUseLptPrint";
            this.cbUseLptPrint.Size = new System.Drawing.Size(102, 16);
            this.cbUseLptPrint.TabIndex = 60;
            this.cbUseLptPrint.Text = "使用LPT打印机";
            this.cbUseLptPrint.UseVisualStyleBackColor = true;
            this.cbUseLptPrint.CheckedChanged += new System.EventHandler(this.cmbUseLptPrint_CheckedChanged);
            // 
            // lstLpt
            // 
            this.lstLpt.FormattingEnabled = true;
            this.lstLpt.Location = new System.Drawing.Point(294, 208);
            this.lstLpt.Name = "lstLpt";
            this.lstLpt.Size = new System.Drawing.Size(59, 20);
            this.lstLpt.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 62;
            this.label2.Text = "端口";
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 403);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstLpt);
            this.Controls.Add(this.cbUseLptPrint);
            this.Controls.Add(this.cbDual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstPrinter);
            this.Controls.Add(this.cbIsPrint);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.cbIsVoice);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.picBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "配置";
            this.Load += new System.EventHandler(this.FormConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox cbIsVoice;
        private System.Windows.Forms.CheckBox cbIsPrint;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBg;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.ComboBox lstPrinter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDual;
        private System.Windows.Forms.CheckBox cbUseLptPrint;
        private System.Windows.Forms.ComboBox lstLpt;
        private System.Windows.Forms.Label label2;
    }
}