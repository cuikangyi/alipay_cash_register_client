namespace Yunfu
{
    partial class PrintOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintOrder));
            this.pageSetupDialog = new System.Windows.Forms.PageSetupDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPname = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCashier_no = new System.Windows.Forms.Label();
            this.lblDevice_name = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalFee = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTradeNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnAutoPrint = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pageSetupDialog
            // 
            this.pageSetupDialog.Document = this.printDocument;
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.Document = this.printDocument;
            this.printDialog.UseEXDialog = true;
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(25, 435);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(66, 23);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "设置";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(96, 435);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(66, 23);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "预览";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(167, 435);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(66, 23);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "打印";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Document = this.printDocument;
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblCashier_no);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.lblPname);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.lblDevice_name);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.lblTotalFee);
            this.groupBox.Controls.Add(this.lblOrderId);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.lblTradeNo);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.lblEmail);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.lblDate);
            this.groupBox.Location = new System.Drawing.Point(26, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(267, 414);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBox_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 377);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "商户名称：";
            // 
            // lblPname
            // 
            this.lblPname.AutoSize = true;
            this.lblPname.Location = new System.Drawing.Point(91, 377);
            this.lblPname.Name = "lblPname";
            this.lblPname.Size = new System.Drawing.Size(53, 12);
            this.lblPname.TabIndex = 15;
            this.lblPname.Text = "lblPname";
            this.lblPname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "收银员编号：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "设备名称：";
            // 
            // lblCashier_no
            // 
            this.lblCashier_no.AutoSize = true;
            this.lblCashier_no.Location = new System.Drawing.Point(91, 349);
            this.lblCashier_no.Name = "lblCashier_no";
            this.lblCashier_no.Size = new System.Drawing.Size(83, 12);
            this.lblCashier_no.TabIndex = 12;
            this.lblCashier_no.Text = "lblCashier_no";
            this.lblCashier_no.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDevice_name
            // 
            this.lblDevice_name.AutoSize = true;
            this.lblDevice_name.Location = new System.Drawing.Point(91, 322);
            this.lblDevice_name.Name = "lblDevice_name";
            this.lblDevice_name.Size = new System.Drawing.Size(89, 12);
            this.lblDevice_name.TabIndex = 11;
            this.lblDevice_name.Text = "lblDevice_name";
            this.lblDevice_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "支付宝交易号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "支付宝收款单";
            // 
            // lblTotalFee
            // 
            this.lblTotalFee.AutoSize = true;
            this.lblTotalFee.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalFee.Location = new System.Drawing.Point(17, 230);
            this.lblTotalFee.Name = "lblTotalFee";
            this.lblTotalFee.Size = new System.Drawing.Size(118, 22);
            this.lblTotalFee.TabIndex = 8;
            this.lblTotalFee.Text = "RMB 00.00";
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(17, 134);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(65, 12);
            this.lblOrderId.TabIndex = 6;
            this.lblOrderId.Text = "lblOrderId";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(17, 263);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 14);
            this.label10.TabIndex = 9;
            this.label10.Text = "日期/时间：";
            // 
            // lblTradeNo
            // 
            this.lblTradeNo.AutoSize = true;
            this.lblTradeNo.Location = new System.Drawing.Point(17, 182);
            this.lblTradeNo.Name = "lblTradeNo";
            this.lblTradeNo.Size = new System.Drawing.Size(65, 12);
            this.lblTradeNo.TabIndex = 7;
            this.lblTradeNo.Text = "lblTradeNo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(17, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "订单号：";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(17, 86);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 12);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "lblEmail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "支付宝账户：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "交易金额：";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 288);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 12);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "lblDate";
            // 
            // btnAutoPrint
            // 
            this.btnAutoPrint.Location = new System.Drawing.Point(238, 435);
            this.btnAutoPrint.Name = "btnAutoPrint";
            this.btnAutoPrint.Size = new System.Drawing.Size(66, 23);
            this.btnAutoPrint.TabIndex = 4;
            this.btnAutoPrint.Text = "直接打印";
            this.btnAutoPrint.UseVisualStyleBackColor = true;
            this.btnAutoPrint.Click += new System.EventHandler(this.btnAutoPrint_Click);
            // 
            // PrintOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(315, 470);
            this.Controls.Add(this.btnAutoPrint);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.btnSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrintOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrintOrder";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PageSetupDialog pageSetupDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTradeNo;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTotalFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAutoPrint;
        private System.Windows.Forms.Label lblCashier_no;
        private System.Windows.Forms.Label lblDevice_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPname;
    }
}