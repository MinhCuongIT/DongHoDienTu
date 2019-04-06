using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DongHoDienTu_1512054
{
    public partial class DigitClock : UserControl
    {

        #region Properties
        private ArrayList arrayList;
        private int ipic1=0, ipic2=0, ipic3=0, ipic4=0;

        

        #endregion

        #region Constructor
        public DigitClock()
        {
            InitializeComponent();
            arrayList = new ArrayList(getArrayImages());
        }

        
        #endregion

        #region Events
        /// <summary>
        /// Bật tính năng đóng cửa sổ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkTurnOn_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkTurnOn.Checked)
            {
                this.label1.Enabled = true;
                this.txtTime.Enabled = true;
                this.btnRun.Enabled = true;
            }
            else
            {
                this.label1.Enabled = false;
                this.txtTime.Enabled = false;
                this.btnRun.Enabled = false;
            }
        }
        /// <summary>
        /// Bắt đầu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            this.timerDigit.Enabled = true;

            this.btnPause.Enabled = true;
            this.btnStop.Enabled = true;
            this.btnStart.Enabled = false;
        }
        /// <summary>
        /// Tạm dừng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPause_Click(object sender, EventArgs e)
        {
            this.timerDigit.Enabled = false;
            this.btnResume.Enabled = true;
            this.btnPause.Enabled = false;
        }
        /// <summary>
        /// Tiếp tục
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnResume_Click(object sender, EventArgs e)
        {
            this.timerDigit.Enabled = true;
            this.btnPause.Enabled = true;
            this.btnResume.Enabled = false;
        }

        /// <summary>
        /// Khởi động Usercontrol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DigitClock_Load(object sender, EventArgs e)
        {
            startClock();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timerDigit.Enabled = false;
            this.btnStart.Enabled = true;
            this.btnPause.Enabled = false;
            this.btnStop.Enabled = false;

            startClock();
        }

        

        private void btnRun_Click(object sender, EventArgs e)
        {

        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        #endregion

        #region Methods
        /// <summary>
        /// Load thư viện hình ảnh từ Resource
        /// </summary>
        /// <returns></returns>
        private ArrayList getArrayImages()
        {
            ArrayList a = new ArrayList();
            a.Add(Properties.Resources._);
            a.Add(Properties.Resources._0);
            a.Add(Properties.Resources._1);
            a.Add(Properties.Resources._2);
            a.Add(Properties.Resources._3);
            a.Add(Properties.Resources._4);
            a.Add(Properties.Resources._5);
            a.Add(Properties.Resources._6);
            a.Add(Properties.Resources._7);
            a.Add(Properties.Resources._8);
            a.Add(Properties.Resources._9);
            return a;
        }
        /// <summary>
        /// Khởi động đồng hồ
        /// </summary>
        private void startClock()
        {
            ipic1 = 0; ipic2 = 0; ipic3 = 0; ipic4 = 0;
            // Bắt đầu từ 00-00
            this.pb1.BackgroundImage = (Image)arrayList[ipic1];
            this.pb2.BackgroundImage = (Image)arrayList[ipic2];
            this.pb3.BackgroundImage = (Image)arrayList[ipic3];
            this.pb4.BackgroundImage = (Image)arrayList[ipic4];
        }
        #endregion

    }
}
