namespace DongHoDienTu_1512054
{
    partial class Form1
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
            this.digitClock1 = new DongHoDienTu_1512054.DigitClock(this);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // digitClock1
            // 
            this.digitClock1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.digitClock1.Location = new System.Drawing.Point(180, 93);
            this.digitClock1.Name = "digitClock1";
            this.digitClock1.Size = new System.Drawing.Size(408, 235);
            this.digitClock1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Demo Usercontrol Đồng Hồ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.digitClock1);
            this.Name = "Form1";
            this.Text = "Demo Chương Trình Đồng Hồ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DigitClock digitClock1;
        private System.Windows.Forms.Label label1;
    }
}

