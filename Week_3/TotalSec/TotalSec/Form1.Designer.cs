namespace TotalSec
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHour = new System.Windows.Forms.TextBox();
            this.txtMinute = new System.Windows.Forms.TextBox();
            this.txtSecond = new System.Windows.Forms.TextBox();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.btnTotalSec = new System.Windows.Forms.Button();
            this.btnHMS = new System.Windows.Forms.Button();
            this.txtTotalSec = new System.Windows.Forms.TextBox();
            this.lblTotalSec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtHour
            // 
            this.txtHour.Location = new System.Drawing.Point(357, 47);
            this.txtHour.Name = "txtHour";
            this.txtHour.Size = new System.Drawing.Size(137, 25);
            this.txtHour.TabIndex = 0;
            // 
            // txtMinute
            // 
            this.txtMinute.Location = new System.Drawing.Point(357, 95);
            this.txtMinute.Name = "txtMinute";
            this.txtMinute.Size = new System.Drawing.Size(137, 25);
            this.txtMinute.TabIndex = 1;
            // 
            // txtSecond
            // 
            this.txtSecond.Location = new System.Drawing.Point(357, 146);
            this.txtSecond.Name = "txtSecond";
            this.txtSecond.Size = new System.Drawing.Size(137, 25);
            this.txtSecond.TabIndex = 2;
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Location = new System.Drawing.Point(289, 50);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(38, 15);
            this.lblHour.TabIndex = 3;
            this.lblHour.Text = "Hour";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(289, 98);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(50, 15);
            this.lblMinute.TabIndex = 4;
            this.lblMinute.Text = "Minute";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(289, 149);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(58, 15);
            this.lblSecond.TabIndex = 5;
            this.lblSecond.Text = "Second";
            // 
            // btnTotalSec
            // 
            this.btnTotalSec.Location = new System.Drawing.Point(188, 47);
            this.btnTotalSec.Name = "btnTotalSec";
            this.btnTotalSec.Size = new System.Drawing.Size(81, 62);
            this.btnTotalSec.TabIndex = 6;
            this.btnTotalSec.Text = "<<";
            this.btnTotalSec.UseVisualStyleBackColor = true;
            this.btnTotalSec.Click += new System.EventHandler(this.btnTotalSec_Click);
            // 
            // btnHMS
            // 
            this.btnHMS.Location = new System.Drawing.Point(188, 115);
            this.btnHMS.Name = "btnHMS";
            this.btnHMS.Size = new System.Drawing.Size(81, 62);
            this.btnHMS.TabIndex = 7;
            this.btnHMS.Text = ">>";
            this.btnHMS.UseVisualStyleBackColor = true;
            this.btnHMS.Click += new System.EventHandler(this.btnHMS_Click);
            // 
            // txtTotalSec
            // 
            this.txtTotalSec.Location = new System.Drawing.Point(26, 95);
            this.txtTotalSec.Name = "txtTotalSec";
            this.txtTotalSec.Size = new System.Drawing.Size(137, 25);
            this.txtTotalSec.TabIndex = 8;
            this.txtTotalSec.Text = "10000";
            // 
            // lblTotalSec
            // 
            this.lblTotalSec.AutoSize = true;
            this.lblTotalSec.Location = new System.Drawing.Point(98, 123);
            this.lblTotalSec.Name = "lblTotalSec";
            this.lblTotalSec.Size = new System.Drawing.Size(65, 15);
            this.lblTotalSec.TabIndex = 9;
            this.lblTotalSec.Text = "TotalSec";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 236);
            this.Controls.Add(this.lblTotalSec);
            this.Controls.Add(this.txtTotalSec);
            this.Controls.Add(this.btnHMS);
            this.Controls.Add(this.btnTotalSec);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.txtSecond);
            this.Controls.Add(this.txtMinute);
            this.Controls.Add(this.txtHour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHour;
        private System.Windows.Forms.TextBox txtMinute;
        private System.Windows.Forms.TextBox txtSecond;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Button btnTotalSec;
        private System.Windows.Forms.Button btnHMS;
        private System.Windows.Forms.TextBox txtTotalSec;
        private System.Windows.Forms.Label lblTotalSec;
    }
}

