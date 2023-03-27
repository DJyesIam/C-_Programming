namespace LinkedList
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(148, 90);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(12, 108);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(148, 90);
            this.btnAppend.TabIndex = 2;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(180, 143);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(102, 25);
            this.txtNum.TabIndex = 3;
            this.txtNum.Text = "0";
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(12, 204);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(148, 90);
            this.btnPop.TabIndex = 4;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 314);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnPrint);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnAppend;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnPop;
    }
}

