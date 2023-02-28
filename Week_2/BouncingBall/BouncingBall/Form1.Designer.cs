namespace BouncingBall
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Timer timer1;
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.picBall = new System.Windows.Forms.PictureBox();
            this.radFast = new System.Windows.Forms.RadioButton();
            this.radSlow = new System.Windows.Forms.RadioButton();
            timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2;
            timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(14, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(256, 225);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // picBall
            // 
            this.picBall.BackColor = System.Drawing.Color.Blue;
            this.picBall.Location = new System.Drawing.Point(14, 15);
            this.picBall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBall.Name = "picBall";
            this.picBall.Size = new System.Drawing.Size(34, 38);
            this.picBall.TabIndex = 1;
            this.picBall.TabStop = false;
            // 
            // radFast
            // 
            this.radFast.AutoSize = true;
            this.radFast.Location = new System.Drawing.Point(214, 15);
            this.radFast.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radFast.Name = "radFast";
            this.radFast.Size = new System.Drawing.Size(56, 19);
            this.radFast.TabIndex = 2;
            this.radFast.TabStop = true;
            this.radFast.Text = "Fast";
            this.radFast.UseVisualStyleBackColor = true;
            // 
            // radSlow
            // 
            this.radSlow.AutoSize = true;
            this.radSlow.Location = new System.Drawing.Point(214, 34);
            this.radSlow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radSlow.Name = "radSlow";
            this.radSlow.Size = new System.Drawing.Size(60, 19);
            this.radSlow.TabIndex = 3;
            this.radSlow.TabStop = true;
            this.radSlow.Text = "Slow";
            this.radSlow.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.radSlow);
            this.Controls.Add(this.radFast);
            this.Controls.Add(this.picBall);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox picBall;
        private System.Windows.Forms.RadioButton radFast;
        private System.Windows.Forms.RadioButton radSlow;
    }
}

