namespace Yunfu
{
    partial class FormOrderList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrderList));
            this.picClose = new System.Windows.Forms.PictureBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.out_trade_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_fee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmt_create = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trade_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trade_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmt_payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buyer_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seller_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPageinfo = new System.Windows.Forms.Label();
            this.forntpage = new System.Windows.Forms.Button();
            this.nextpage = new System.Windows.Forms.Button();
            this.btnFresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(656, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(49, 37);
            this.picClose.TabIndex = 17;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subject,
            this.out_trade_no,
            this.total_fee,
            this.gmt_create,
            this.trade_status,
            this.trade_no,
            this.gmt_payment,
            this.buyer_email,
            this.seller_email,
            this.cashier_name});
            this.dgvList.Location = new System.Drawing.Point(12, 90);
            this.dgvList.MultiSelect = false;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(693, 283);
            this.dgvList.TabIndex = 18;
            this.dgvList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellClick);
            // 
            // subject
            // 
            this.subject.DataPropertyName = "subject";
            this.subject.HeaderText = "订单名称";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Visible = false;
            this.subject.Width = 120;
            // 
            // out_trade_no
            // 
            this.out_trade_no.DataPropertyName = "out_trade_no";
            this.out_trade_no.HeaderText = "商户订单号";
            this.out_trade_no.Name = "out_trade_no";
            this.out_trade_no.ReadOnly = true;
            this.out_trade_no.Width = 150;
            // 
            // total_fee
            // 
            this.total_fee.DataPropertyName = "total_fee";
            this.total_fee.HeaderText = "金额";
            this.total_fee.Name = "total_fee";
            this.total_fee.ReadOnly = true;
            this.total_fee.Width = 60;
            // 
            // gmt_create
            // 
            this.gmt_create.DataPropertyName = "gmt_create";
            this.gmt_create.HeaderText = "创建时间";
            this.gmt_create.Name = "gmt_create";
            this.gmt_create.ReadOnly = true;
            this.gmt_create.Width = 120;
            // 
            // trade_status
            // 
            this.trade_status.DataPropertyName = "trade_status";
            this.trade_status.HeaderText = "支付状态";
            this.trade_status.Name = "trade_status";
            this.trade_status.ReadOnly = true;
            this.trade_status.Width = 80;
            // 
            // trade_no
            // 
            this.trade_no.DataPropertyName = "trade_no";
            this.trade_no.HeaderText = "支付宝交易号";
            this.trade_no.Name = "trade_no";
            this.trade_no.ReadOnly = true;
            this.trade_no.Width = 120;
            // 
            // gmt_payment
            // 
            this.gmt_payment.DataPropertyName = "gmt_payment";
            this.gmt_payment.HeaderText = "支付时间";
            this.gmt_payment.Name = "gmt_payment";
            this.gmt_payment.ReadOnly = true;
            this.gmt_payment.Width = 120;
            // 
            // buyer_email
            // 
            this.buyer_email.DataPropertyName = "buyer_email";
            this.buyer_email.HeaderText = "顾客支付宝账号";
            this.buyer_email.Name = "buyer_email";
            this.buyer_email.ReadOnly = true;
            this.buyer_email.Width = 120;
            // 
            // seller_email
            // 
            this.seller_email.DataPropertyName = "seller_email";
            this.seller_email.HeaderText = "商户支付宝账号";
            this.seller_email.Name = "seller_email";
            this.seller_email.ReadOnly = true;
            this.seller_email.Width = 120;
            // 
            // cashier_name
            // 
            this.cashier_name.DataPropertyName = "cashier_name";
            this.cashier_name.HeaderText = "收银员";
            this.cashier_name.Name = "cashier_name";
            this.cashier_name.ReadOnly = true;
            // 
            // lblPageinfo
            // 
            this.lblPageinfo.AutoSize = true;
            this.lblPageinfo.Location = new System.Drawing.Point(552, 395);
            this.lblPageinfo.Name = "lblPageinfo";
            this.lblPageinfo.Size = new System.Drawing.Size(71, 12);
            this.lblPageinfo.TabIndex = 19;
            this.lblPageinfo.Text = "lblPageinfo";
            // 
            // forntpage
            // 
            this.forntpage.Location = new System.Drawing.Point(394, 390);
            this.forntpage.Name = "forntpage";
            this.forntpage.Size = new System.Drawing.Size(75, 23);
            this.forntpage.TabIndex = 20;
            this.forntpage.Text = "上一页";
            this.forntpage.UseVisualStyleBackColor = true;
            this.forntpage.Click += new System.EventHandler(this.forntpage_Click);
            // 
            // nextpage
            // 
            this.nextpage.Location = new System.Drawing.Point(471, 390);
            this.nextpage.Name = "nextpage";
            this.nextpage.Size = new System.Drawing.Size(75, 23);
            this.nextpage.TabIndex = 21;
            this.nextpage.Text = "下一页";
            this.nextpage.UseVisualStyleBackColor = true;
            this.nextpage.Click += new System.EventHandler(this.nextpage_Click);
            // 
            // btnFresh
            // 
            this.btnFresh.Location = new System.Drawing.Point(25, 390);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(75, 23);
            this.btnFresh.TabIndex = 22;
            this.btnFresh.Text = "刷新";
            this.btnFresh.UseVisualStyleBackColor = true;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(717, 66);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(115, 390);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 24;
            this.btnPrint.Text = "打印此订单";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormOrderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 433);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.nextpage);
            this.Controls.Add(this.forntpage);
            this.Controls.Add(this.lblPageinfo);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormOrderList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "订单查询";
            this.Load += new System.EventHandler(this.FormOrderList_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PayList_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PayList_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lblPageinfo;
        private System.Windows.Forms.Button forntpage;
        private System.Windows.Forms.Button nextpage;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn out_trade_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_fee;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmt_create;
        private System.Windows.Forms.DataGridViewTextBoxColumn trade_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn trade_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmt_payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn buyer_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn seller_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashier_name;
        private System.Windows.Forms.Button btnPrint;
    }
}