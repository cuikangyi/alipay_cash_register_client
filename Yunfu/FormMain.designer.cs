namespace Yunfu
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.picBg = new System.Windows.Forms.PictureBox();
            this.txtTotal_fee = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMsg2 = new System.Windows.Forms.Label();
            this.lblMsg1 = new System.Windows.Forms.Label();
            this.txtDynamic_id = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabelYunfuInfo = new System.Windows.Forms.LinkLabel();
            this.picBg2 = new System.Windows.Forms.PictureBox();
            this.lblTotal_fee = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.显示ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg2)).BeginInit();
            this.cmsNotify.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBg
            // 
            this.picBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBg.Image = ((System.Drawing.Image)(resources.GetObject("picBg.Image")));
            this.picBg.Location = new System.Drawing.Point(0, 0);
            this.picBg.Name = "picBg";
            this.picBg.Size = new System.Drawing.Size(727, 520);
            this.picBg.TabIndex = 11;
            this.picBg.TabStop = false;
            this.picBg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBg_MouseDown);
            this.picBg.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBg_MouseMove);
            // 
            // txtTotal_fee
            // 
            this.txtTotal_fee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtTotal_fee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotal_fee.Font = new System.Drawing.Font("宋体", 34F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTotal_fee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.txtTotal_fee.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtTotal_fee.Location = new System.Drawing.Point(236, 238);
            this.txtTotal_fee.MaxLength = 11;
            this.txtTotal_fee.Name = "txtTotal_fee";
            this.txtTotal_fee.Size = new System.Drawing.Size(310, 52);
            this.txtTotal_fee.TabIndex = 1;
            this.txtTotal_fee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotal_fee_KeyPress);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(172, 321);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(388, 43);
            this.btnOK.TabIndex = 13;
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(0, 134);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(725, 49);
            this.btnClear.TabIndex = 26;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMsg2
            // 
            this.lblMsg2.AutoSize = true;
            this.lblMsg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lblMsg2.Font = new System.Drawing.Font("宋体", 9F);
            this.lblMsg2.ForeColor = System.Drawing.Color.Red;
            this.lblMsg2.Location = new System.Drawing.Point(234, 430);
            this.lblMsg2.Name = "lblMsg2";
            this.lblMsg2.Size = new System.Drawing.Size(47, 12);
            this.lblMsg2.TabIndex = 27;
            this.lblMsg2.Text = "lblMsg2";
            this.lblMsg2.Visible = false;
            // 
            // lblMsg1
            // 
            this.lblMsg1.AutoSize = true;
            this.lblMsg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lblMsg1.ForeColor = System.Drawing.Color.Red;
            this.lblMsg1.Location = new System.Drawing.Point(191, 306);
            this.lblMsg1.Name = "lblMsg1";
            this.lblMsg1.Size = new System.Drawing.Size(47, 12);
            this.lblMsg1.TabIndex = 28;
            this.lblMsg1.Text = "lblMsg1";
            // 
            // txtDynamic_id
            // 
            this.txtDynamic_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.txtDynamic_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDynamic_id.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.txtDynamic_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.txtDynamic_id.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtDynamic_id.Location = new System.Drawing.Point(489, 426);
            this.txtDynamic_id.MaxLength = 20;
            this.txtDynamic_id.Name = "txtDynamic_id";
            this.txtDynamic_id.Size = new System.Drawing.Size(189, 19);
            this.txtDynamic_id.TabIndex = 2;
            this.txtDynamic_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDynamic_id_KeyPress);
            // 
            // btnList
            // 
            this.btnList.Image = ((System.Drawing.Image)(resources.GetObject("btnList.Image")));
            this.btnList.Location = new System.Drawing.Point(632, 7);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(25, 26);
            this.btnList.TabIndex = 33;
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(694, 7);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 26);
            this.btnClose.TabIndex = 32;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.Location = new System.Drawing.Point(663, 7);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(25, 26);
            this.btnMin.TabIndex = 31;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnConf
            // 
            this.btnConf.Image = ((System.Drawing.Image)(resources.GetObject("btnConf.Image")));
            this.btnConf.Location = new System.Drawing.Point(601, 7);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(25, 26);
            this.btnConf.TabIndex = 30;
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.label5.Location = new System.Drawing.Point(50, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 34;
            this.label5.Text = "收款客户端";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(8, 499);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 36;
            this.label6.Text = "技术支持：";
            // 
            // linkLabelYunfuInfo
            // 
            this.linkLabelYunfuInfo.AutoSize = true;
            this.linkLabelYunfuInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.linkLabelYunfuInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLabelYunfuInfo.Location = new System.Drawing.Point(71, 499);
            this.linkLabelYunfuInfo.Name = "linkLabelYunfuInfo";
            this.linkLabelYunfuInfo.Size = new System.Drawing.Size(149, 12);
            this.linkLabelYunfuInfo.TabIndex = 35;
            this.linkLabelYunfuInfo.TabStop = true;
            this.linkLabelYunfuInfo.Text = "XX公司";
            this.linkLabelYunfuInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelYunfuInfo_LinkClicked);
            // 
            // picBg2
            // 
            this.picBg2.Image = ((System.Drawing.Image)(resources.GetObject("picBg2.Image")));
            this.picBg2.Location = new System.Drawing.Point(1, 178);
            this.picBg2.Name = "picBg2";
            this.picBg2.Size = new System.Drawing.Size(723, 306);
            this.picBg2.TabIndex = 37;
            this.picBg2.TabStop = false;
            this.picBg2.Visible = false;
            // 
            // lblTotal_fee
            // 
            this.lblTotal_fee.AutoSize = true;
            this.lblTotal_fee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.lblTotal_fee.Font = new System.Drawing.Font("宋体", 38F, System.Drawing.FontStyle.Bold);
            this.lblTotal_fee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(104)))), ((int)(((byte)(141)))));
            this.lblTotal_fee.Location = new System.Drawing.Point(258, 213);
            this.lblTotal_fee.Name = "lblTotal_fee";
            this.lblTotal_fee.Size = new System.Drawing.Size(130, 51);
            this.lblTotal_fee.TabIndex = 38;
            this.lblTotal_fee.Text = "0.00";
            this.lblTotal_fee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal_fee.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.cmsNotify;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "收银台";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // cmsNotify
            // 
            this.cmsNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示ToolStripMenuItem,
            this.隐藏ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.cmsNotify.Name = "cmsNotify";
            this.cmsNotify.Size = new System.Drawing.Size(101, 70);
            // 
            // 显示ToolStripMenuItem
            // 
            this.显示ToolStripMenuItem.Name = "显示ToolStripMenuItem";
            this.显示ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.显示ToolStripMenuItem.Text = "显示";
            this.显示ToolStripMenuItem.Click += new System.EventHandler(this.显示ToolStripMenuItem_Click);
            // 
            // 隐藏ToolStripMenuItem
            // 
            this.隐藏ToolStripMenuItem.Name = "隐藏ToolStripMenuItem";
            this.隐藏ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.隐藏ToolStripMenuItem.Text = "隐藏";
            this.隐藏ToolStripMenuItem.Click += new System.EventHandler(this.隐藏ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfo.Location = new System.Drawing.Point(322, 499);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(397, 12);
            this.lblInfo.TabIndex = 40;
            this.lblInfo.Text = "lblInfo";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblVersion.Location = new System.Drawing.Point(143, 16);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(47, 12);
            this.lblVersion.TabIndex = 41;
            this.lblVersion.Text = "0.0.0.0";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(727, 520);
            this.ControlBox = false;
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblTotal_fee);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMsg1);
            this.Controls.Add(this.lblMsg2);
            this.Controls.Add(this.txtDynamic_id);
            this.Controls.Add(this.picBg2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabelYunfuInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTotal_fee);
            this.Controls.Add(this.picBg);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "云付-收银台";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBg2)).EndInit();
            this.cmsNotify.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBg;
        private System.Windows.Forms.TextBox txtTotal_fee;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMsg2;
        private System.Windows.Forms.Label lblMsg1;
        private System.Windows.Forms.TextBox txtDynamic_id;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnConf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabelYunfuInfo;
        private System.Windows.Forms.PictureBox picBg2;
        private System.Windows.Forms.Label lblTotal_fee;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ContextMenuStrip cmsNotify;
        private System.Windows.Forms.ToolStripMenuItem 显示ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.Label lblVersion;
    }
}

