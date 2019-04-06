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
        /// <summary>
        /// Mảng các hình ảnh
        /// </summary>
        private ArrayList arrayList;
        /// <summary>
        /// index của các hình anh trong picturebox
        /// </summary>
        private int ipic1 = 0, ipic2 = 0, ipic3 = 0, ipic4 = 0;

        /// <summary>
        /// Form chứa Usercontrol này
        /// </summary>
        private Form frm;

        /// <summary>
        /// Cờ hiệu kiểm tra tính năng tự đóng cửa sổ
        /// </summary>
        private bool flag = false;
        #endregion

        #region Constructor
        /// <summary>
        /// Hàm dựng mặc định
        /// </summary>
        public DigitClock(Form form)
        {
            InitializeComponent();
            this.frm = form;
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
                this.btnStop_Click(null, null);
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
        /// <summary>
        /// Dừng lại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStop_Click(object sender, EventArgs e)
        {
            this.timerDigit.Enabled = false;
            this.btnStart.Enabled = true;
            this.btnPause.Enabled = false;
            this.btnStop.Enabled = false;
            if (this.chkTurnOn.Checked && !btnRun.Enabled)
            {
                this.btnRun.Enabled = true;
            }

            startClock();
        }
        /// <summary>
        /// Chạy chương trình đóng cửa sổ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            this.flag = true;
            this.btnStart_Click(null, null);
            this.btnRun.Enabled = false;
        }
        /// <summary>
        /// Xử lí khi đồng hồ chạy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private int count = 0;
        private void timerDigit_Tick(object sender, EventArgs e)
        {
            this.count++;
            this.ipic4++;
            if (this.ipic4 > 9)
            {
                this.ipic4 = 0;
                this.pb4.Image = (Image)arrayList[this.ipic4];
                this.ipic3++;
                if (this.ipic3 == 6)
                {
                    this.ipic3 = 0;
                    this.pb3.Image = (Image)arrayList[this.ipic3];
                    this.ipic2++;
                    if (this.ipic2 > 9)
                    {
                        this.ipic2 = 0;
                        this.pb2.Image = (Image)arrayList[this.ipic2];
                        this.ipic1++;
                        this.pb1.Image = (Image)arrayList[this.ipic1];
                        if (this.ipic1 == 6)
                            return;
                    }
                    this.pb2.Image = (Image)arrayList[this.ipic2];
                    return;
                }
                this.pb3.Image = (Image)arrayList[this.ipic3];
                return;
            }
            this.pb4.Image = (Image)arrayList[this.ipic4];
            //bật chươn trình đóng cửa sổ
            if (this.flag && ((this.count / 60) == int.Parse(this.txtTime.Text)))
            {
                this.timerDigit.Stop();
                this.frm.Close();
            }
        }
        /// <summary>
        /// Chỉ cho nhập số
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            this.pb1.Image = (Image)arrayList[ipic1];
            this.pb2.Image = (Image)arrayList[ipic2];
            this.pb3.Image = (Image)arrayList[ipic3];
            this.pb4.Image = (Image)arrayList[ipic4];
        }
        #endregion

    }
}
