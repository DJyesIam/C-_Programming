namespace DayOfWeek
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
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.btnDayOfWeek = new System.Windows.Forms.Button();
            this.btnLeapYear = new System.Windows.Forms.Button();
            this.lblOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(26, 25);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(166, 25);
            this.txtYear.TabIndex = 0;
            // 
            // txtDay
            // 
            this.txtDay.Location = new System.Drawing.Point(26, 135);
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(166, 25);
            this.txtDay.TabIndex = 1;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(26, 77);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(166, 25);
            this.txtMonth.TabIndex = 2;
            // 
            // btnDayOfWeek
            // 
            this.btnDayOfWeek.Location = new System.Drawing.Point(243, 12);
            this.btnDayOfWeek.Name = "btnDayOfWeek";
            this.btnDayOfWeek.Size = new System.Drawing.Size(114, 78);
            this.btnDayOfWeek.TabIndex = 3;
            this.btnDayOfWeek.Text = "Day Of Week";
            this.btnDayOfWeek.UseVisualStyleBackColor = true;
            this.btnDayOfWeek.Click += new System.EventHandler(this.btnDayOfWeek_Click);
            // 
            // btnLeapYear
            // 
            this.btnLeapYear.Location = new System.Drawing.Point(243, 106);
            this.btnLeapYear.Name = "btnLeapYear";
            this.btnLeapYear.Size = new System.Drawing.Size(114, 78);
            this.btnLeapYear.TabIndex = 4;
            this.btnLeapYear.Text = "윤년 판단";
            this.btnLeapYear.UseVisualStyleBackColor = true;
            this.btnLeapYear.Click += new System.EventHandler(this.btnLeapYear_Click);
            // 
            // lblOut
            // 
            this.lblOut.AutoSize = true;
            this.lblOut.Location = new System.Drawing.Point(374, 44);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(37, 15);
            this.lblOut.TabIndex = 5;
            this.lblOut.Text = "결과";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 231);
            this.Controls.Add(this.lblOut);
            this.Controls.Add(this.btnLeapYear);
            this.Controls.Add(this.btnDayOfWeek);
            this.Controls.Add(this.txtMonth);
            this.Controls.Add(this.txtDay);
            this.Controls.Add(this.txtYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.TextBox txtMonth;
        private System.Windows.Forms.Button btnDayOfWeek;
        private System.Windows.Forms.Button btnLeapYear;
        private System.Windows.Forms.Label lblOut;
    }
}

