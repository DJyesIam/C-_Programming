namespace Branch
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
            this.btnCheckGrade = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckGrade
            // 
            this.btnCheckGrade.Location = new System.Drawing.Point(283, 46);
            this.btnCheckGrade.Name = "btnCheckGrade";
            this.btnCheckGrade.Size = new System.Drawing.Size(147, 93);
            this.btnCheckGrade.TabIndex = 0;
            this.btnCheckGrade.Text = "학점 확인";
            this.btnCheckGrade.UseVisualStyleBackColor = true;
            this.btnCheckGrade.Click += new System.EventHandler(this.btnCheckGrade_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(38, 60);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(196, 25);
            this.txtInput.TabIndex = 1;
            this.txtInput.Text = "0";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(35, 112);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(37, 15);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "학점";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 187);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnCheckGrade);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckGrade;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput;
    }
}

