namespace Constructor
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
            this.btnMakeCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNCat = new System.Windows.Forms.Label();
            this.btnNCat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMakeCat
            // 
            this.btnMakeCat.Location = new System.Drawing.Point(12, 12);
            this.btnMakeCat.Name = "btnMakeCat";
            this.btnMakeCat.Size = new System.Drawing.Size(145, 88);
            this.btnMakeCat.TabIndex = 0;
            this.btnMakeCat.Text = "고양이 만들기";
            this.btnMakeCat.UseVisualStyleBackColor = true;
            this.btnMakeCat.Click += new System.EventHandler(this.btnMakeCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "고양이 수";
            // 
            // lblNCat
            // 
            this.lblNCat.AutoSize = true;
            this.lblNCat.Location = new System.Drawing.Point(191, 66);
            this.lblNCat.Name = "lblNCat";
            this.lblNCat.Size = new System.Drawing.Size(15, 15);
            this.lblNCat.TabIndex = 2;
            this.lblNCat.Text = "0";
            // 
            // btnNCat
            // 
            this.btnNCat.Location = new System.Drawing.Point(12, 106);
            this.btnNCat.Name = "btnNCat";
            this.btnNCat.Size = new System.Drawing.Size(145, 88);
            this.btnNCat.TabIndex = 3;
            this.btnNCat.Text = "고양이 수";
            this.btnNCat.UseVisualStyleBackColor = true;
            this.btnNCat.Click += new System.EventHandler(this.btnNCat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 209);
            this.Controls.Add(this.btnNCat);
            this.Controls.Add(this.lblNCat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMakeCat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMakeCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNCat;
        private System.Windows.Forms.Button btnNCat;
    }
}

