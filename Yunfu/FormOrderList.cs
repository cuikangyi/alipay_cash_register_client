using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YunfuBLL;
using YunfuModel;
using YunfuTools;

namespace Yunfu
{
    public partial class FormOrderList : Form
    {
        public int selPageIndex = 1;
        public int selPageSize = 10;
        public int reCount = 0;
        public decimal pageCount = 0m;
        private Point mypoint;
        private OrderBLL ob = new OrderBLL();

        public FormOrderList()
        {
            InitializeComponent();
            string xml = ob.getOrderCount();
            try
            {
                string is_success = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/is_success").InnerText;
                if (is_success == "T")
                {
                    string count = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/count").InnerText;
                    reCount = Convert.ToInt32(count);
                }
                else
                {
                    string error_msg = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/error_msg").InnerText;
                    this.lblPageinfo.Text = error_msg;
                }
            }
            catch (Exception ex)
            {
                this.lblPageinfo.Text = "异常：" + ex.Message;
            }
                

            this.dgvList.AutoGenerateColumns = false;
            BindData();
        }
        private void FormOrderList_Load(object sender, EventArgs e)
        {

        }
        public void BindData()
        {
            try
            {
                DataTable orderList = ob.getOrderList(selPageSize,selPageIndex);
                this.dgvList.DataSource = orderList;
                this.pageCount = Math.Ceiling(Convert.ToDecimal(this.reCount) / Convert.ToDecimal(this.selPageSize));
                if(reCount > 0){
                    this.lblPageinfo.Text = string.Concat(new object[]
				    {
					    "当前第",
					    this.selPageIndex,
					    "页；共",
					    this.pageCount,
					    "页"
				    });
                }
                else
                {
                    this.lblPageinfo.Text = "无订单信息";
                }
            }
            catch (Exception ex)
            {
                this.lblPageinfo.Text = "异常：" + ex.Message.ToString();
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void forntpage_Click(object sender, EventArgs e)
        {
            if (this.selPageIndex > 1)
            {
                this.selPageIndex--;
                this.BindData();
            }
        }

        private void nextpage_Click(object sender, EventArgs e)
        {
            if (this.selPageIndex < this.pageCount)
            {
                this.selPageIndex++;
                this.BindData();
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            this.selPageIndex = 1;
            this.BindData();
        }

        private void PayList_MouseDown(object sender, MouseEventArgs e)
        {
            mypoint = new Point(-e.X, -e.Y);
        }

        private void PayList_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myposition = Control.MousePosition;
                myposition.Offset(mypoint.X, mypoint.Y);
                this.DesktopLocation = myposition;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            mypoint = new Point(-e.X, -e.Y);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point myposition = Control.MousePosition;
                myposition.Offset(mypoint.X, mypoint.Y);
                this.DesktopLocation = myposition;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                
                string pay_status = dgvList.SelectedRows[0].Cells[4].Value.ToString();;
                if (pay_status == "已支付")
                {
                    OrderModel om = new OrderModel();
                    om.Out_trade_no = dgvList.SelectedRows[0].Cells[1].Value.ToString();
                    om.Buyer_email = dgvList.SelectedRows[0].Cells[7].Value.ToString();
                    PrintUtils.printOrder(om);
                }
                else
                {
                    MessageHelper.ShowTips("此订单未付款！" + pay_status);
                }

            }catch(Exception ex)
            {
                MessageHelper.ShowError("没有选择任何订单！");
            }
            
        }

        private OrderModel getOrderDetail(OrderModel order)
        {
            OrderBLL ob = new OrderBLL();
            string xml = ob.getOrderDetail(order.Out_trade_no);
            try
            {
                string is_success = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/is_success").InnerText;
                if (is_success == "T")
                {
                    //order.Out_trade_no = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/out_trade_no").InnerText;
                    order.Subject = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/subject").InnerText;
                    order.Total_fee = Convert.ToDecimal(XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/total_fee").InnerText);
                    //order.Buyer_email = om.Buyer_email;
                    order.Trade_no = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/trade_no").InnerText;
                    order.Gmt_create = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/gmt_create").InnerText;
                    order.Gmt_payment = XMLStrHelper.GetXmlNodeByXpath(xml, "Alipay/order/gmt_payment").InnerText;
                    return order;
                }
                else
                {
                    return order;
                }
            }
            catch (Exception ex)
            {
                return order;
            }
        }

        private void dgvList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string pay_status = dgvList.SelectedRows[0].Cells[4].Value.ToString(); ;
                if (pay_status == "已支付")
                {
                    btnPrint.Enabled = true;
                }
                else
                {
                    btnPrint.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
