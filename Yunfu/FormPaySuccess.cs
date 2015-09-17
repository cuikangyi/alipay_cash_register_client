using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
using YunfuModel;

namespace Yunfu
{
    public partial class FormPaySuccess : Form
    {
        private static int mm = 0;
        private int waittime = 3;

        public FormPaySuccess(OrderModel order)
        {
            InitializeComponent();

            lblFee.Text = order.Total_fee.ToString();
            lblBuyEmail.Text = order.Buyer_email;
            
            timer1.Enabled = true;
            BeginAnimate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mm >= waittime)
            {
                this.timer1.Enabled = false;
                this.Close();
            }
            mm++;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BeginAnimate()
        {
            if (StaticData.Config.isVoice == "1")
            {
                SoundPlayer soundPlayer = new SoundPlayer();
                soundPlayer.SoundLocation = Application.StartupPath + "//folder.wav";
                if (File.Exists(soundPlayer.SoundLocation))
                {
                    soundPlayer.Load();
                    soundPlayer.Play();
                }
            }
        }
    }
}
