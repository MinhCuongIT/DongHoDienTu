namespace DongHoDienTu_1512054
{
    partial class DigitClock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb0 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.chkTurnOn = new System.Windows.Forms.CheckBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.timerDigit = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pb1);
            this.groupBox1.Controls.Add(this.pb4);
            this.groupBox1.Controls.Add(this.pb3);
            this.groupBox1.Controls.Add(this.pb0);
            this.groupBox1.Controls.Add(this.pb2);
            this.groupBox1.Location = new System.Drawing.Point(49, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 91);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.Image = global::DongHoDienTu_1512054.Properties.Resources._0;
            this.pb1.Location = new System.Drawing.Point(67, 19);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(40, 50);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 5;
            this.pb1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::DongHoDienTu_1512054.Properties.Resources._0;
            this.pb4.Location = new System.Drawing.Point(220, 19);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(40, 50);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 4;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::DongHoDienTu_1512054.Properties.Resources._0;
            this.pb3.Location = new System.Drawing.Point(182, 19);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(40, 50);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 3;
            this.pb3.TabStop = false;
            // 
            // pb0
            // 
            this.pb0.Image = global::DongHoDienTu_1512054.Properties.Resources._;
            this.pb0.Location = new System.Drawing.Point(144, 19);
            this.pb0.Name = "pb0";
            this.pb0.Size = new System.Drawing.Size(40, 50);
            this.pb0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb0.TabIndex = 2;
            this.pb0.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::DongHoDienTu_1512054.Properties.Resources._0;
            this.pb2.Location = new System.Drawing.Point(106, 19);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(40, 50);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // chkTurnOn
            // 
            this.chkTurnOn.AutoSize = true;
            this.chkTurnOn.Location = new System.Drawing.Point(18, 15);
            this.chkTurnOn.Name = "chkTurnOn";
            this.chkTurnOn.Size = new System.Drawing.Size(107, 17);
            this.chkTurnOn.TabIndex = 1;
            this.chkTurnOn.Text = "Đóng cửa sổ này";
            this.chkTurnOn.UseVisualStyleBackColor = true;
            this.chkTurnOn.CheckedChanged += new System.EventHandler(this.chkTurnOn_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(49, 115);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 33);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Location = new System.Drawing.Point(130, 115);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 33);
            this.btnPause.TabIndex = 3;
            this.btnPause.Text = "Tạm dừng";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.Enabled = false;
            this.btnResume.Location = new System.Drawing.Point(211, 115);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(75, 33);
            this.btnResume.TabIndex = 4;
            this.btnResume.Text = "Tiếp tục";
            this.btnResume.UseVisualStyleBackColor = true;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(291, 115);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 33);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Dừng lại";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(67, 37);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 6;
            this.txtTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTime_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Số phút:";
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(173, 35);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 8;
            this.btnRun.Text = "Chạy";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // timerDigit
            // 
            this.timerDigit.Interval = 1000;
            this.timerDigit.Tick += new System.EventHandler(this.timerDigit_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRun);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTime);
            this.groupBox2.Controls.Add(this.chkTurnOn);
            this.groupBox2.Location = new System.Drawing.Point(77, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 73);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // DigitClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Name = "DigitClock";
            this.Size = new System.Drawing.Size(408, 235);
            this.Load += new System.EventHandler(this.DigitClock_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb0;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.CheckBox chkTurnOn;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timerDigit;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pb1;
    }
}
