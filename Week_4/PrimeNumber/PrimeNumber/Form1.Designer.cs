namespace PrimeNumber
{
    partial class PrimeNumber10000th
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.PrimeNumber2to10000 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(180, 12);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(155, 86);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "소수 검사";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // PrimeNumber2to10000
            // 
            this.PrimeNumber2to10000.Location = new System.Drawing.Point(180, 104);
            this.PrimeNumber2to10000.Name = "PrimeNumber2to10000";
            this.PrimeNumber2to10000.Size = new System.Drawing.Size(155, 86);
            this.PrimeNumber2to10000.TabIndex = 1;
            this.PrimeNumber2to10000.Text = "2에서 10000까지의 소수 개수";
            this.PrimeNumber2to10000.UseVisualStyleBackColor = true;
            this.PrimeNumber2to10000.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 86);
            this.button3.TabIndex = 2;
            this.button3.Text = "10000번째 소수";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 122);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(142, 25);
            this.txtInput.TabIndex = 3;
            this.txtInput.Text = "257";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 150);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(37, 15);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "결과";
            // 
            // PrimeNumber10000th
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 306);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.PrimeNumber2to10000);
            this.Controls.Add(this.btnCheck);
            this.Name = "PrimeNumber10000th";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button PrimeNumber2to10000;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblOutput;
    }
}

