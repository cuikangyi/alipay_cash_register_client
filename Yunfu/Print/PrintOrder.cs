using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YunfuModel;
using YunfuBLL;
using YunfuTools;

namespace Yunfu
{
    public partial class PrintOrder : Form
    {
        public PrintOrder(OrderModel om)
        {
            InitializeComponent();
            orderDetail(om);
        }
        public PrintOrder()
        {
            InitializeComponent();
        }

        private void orderDetail(OrderModel order)
        {
            lblEmail.Text = order.Buyer_email;
            lblOrderId.Text = order.Out_trade_no;
            lblTotalFee.Text = order.Total_fee.ToString();
            lblTradeNo.Text = order.Trade_no;
            lblDate.Text = order.Gmt_payment;
            lblDevice_name.Text = StaticData.Device.device_name;
            lblCashier_no.Text = StaticData.Cashier.cashier_no;
            lblPname.Text = StaticData.Device.pname;    
        }

        public void print()
        {
            if (StaticData.Config.printerName != "" || StaticData.Config.printerName != null)
            {
                this.printDocument.PrinterSettings.PrinterName = StaticData.Config.printerName;
            }

            if (StaticData.Config.dualPrint == "1")
            {
                this.printDocument.Print();
            }
            this.printDocument.Print();
            base.Dispose();
            base.Close();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            this.pageSetupDialog.ShowDialog();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog.ShowDialog();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.printDialog.ShowDialog() == DialogResult.OK)
            {
                this.printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ////打印内容 为 局部的 this.groupBox1
            Bitmap _NewBitmap = new Bitmap(groupBox.Width, groupBox.Height);
            groupBox.DrawToBitmap(_NewBitmap, new Rectangle(0, 0, _NewBitmap.Width, _NewBitmap.Height));
            e.Graphics.DrawImage(_NewBitmap, 0, 0, _NewBitmap.Width, _NewBitmap.Height);
        }

        //去掉groupbox边框
        private void groupBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(groupBox.BackColor);
            Rectangle Rtg_LT = new Rectangle();
            Rectangle Rtg_RT = new Rectangle();
            Rectangle Rtg_LB = new Rectangle();
            Rectangle Rtg_RB = new Rectangle();
            Rtg_LT.X = 0; Rtg_LT.Y = 7; Rtg_LT.Width = 10; Rtg_LT.Height = 10;
            Rtg_RT.X = e.ClipRectangle.Width - 11; Rtg_RT.Y = 7; Rtg_RT.Width = 10; Rtg_RT.Height = 10;
            Rtg_LB.X = 0; Rtg_LB.Y = e.ClipRectangle.Height - 11; Rtg_LB.Width = 10; Rtg_LB.Height = 10;
            Rtg_RB.X = e.ClipRectangle.Width - 11; Rtg_RB.Y = e.ClipRectangle.Height - 11; Rtg_RB.Width = 10; Rtg_RB.Height = 10;
            Color color = Color.FromArgb(255, 255, 255);
            Pen Pen_AL = new Pen(color, 1);
            Pen_AL.Color = color;
            Brush brush = new HatchBrush(HatchStyle.Divot, color);
            e.Graphics.DrawString(groupBox.Text, groupBox.Font, brush, 6, 0);
            e.Graphics.DrawArc(Pen_AL, Rtg_LT, 180, 90);
            e.Graphics.DrawArc(Pen_AL, Rtg_RT, 270, 90);
            e.Graphics.DrawArc(Pen_AL, Rtg_LB, 90, 90);
            e.Graphics.DrawArc(Pen_AL, Rtg_RB, 0, 90);
            e.Graphics.DrawLine(Pen_AL, 5, 7, 6, 7);
            e.Graphics.DrawLine(Pen_AL, e.Graphics.MeasureString(groupBox.Text, groupBox.Font).Width + 3, 7, e.ClipRectangle.Width - 7, 7);
            e.Graphics.DrawLine(Pen_AL, 0, 13, 0, e.ClipRectangle.Height - 7);
            e.Graphics.DrawLine(Pen_AL, 6, e.ClipRectangle.Height - 1, e.ClipRectangle.Width - 7, e.ClipRectangle.Height - 1);
            e.Graphics.DrawLine(Pen_AL, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 7, e.ClipRectangle.Width - 1, 13);
        }

        private void btnAutoPrint_Click(object sender, EventArgs e)
        {
            this.print();
        }
    }
}
