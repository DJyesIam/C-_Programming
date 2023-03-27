namespace Linked
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
            this.btnMake = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnPrepend = new System.Windows.Forms.Button();
            this.btnAppend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(27, 28);
            this.btnMake.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(114, 89);
            this.btnMake.TabIndex = 0;
            this.btnMake.Text = "Make";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(194, 28);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(114, 89);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPrepend
            // 
            this.btnPrepend.Location = new System.Drawing.Point(27, 124);
            this.btnPrepend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrepend.Name = "btnPrepend";
            this.btnPrepend.Size = new System.Drawing.Size(114, 89);
            this.btnPrepend.TabIndex = 2;
            this.btnPrepend.Text = "Prepend";
            this.btnPrepend.UseVisualStyleBackColor = true;
            this.btnPrepend.Click += new System.EventHandler(this.btnPrepend_Click);
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(27, 220);
            this.btnAppend.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(114, 89);
            this.btnAppend.TabIndex = 3;
            this.btnAppend.Text = "Append";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 335);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.btnPrepend);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnMake);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnPrepend;
        private System.Windows.Forms.Button btnAppend;
    }
}

