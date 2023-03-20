namespace MonteCarloTriangle
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
            this.lblRatioMonte = new System.Windows.Forms.Label();
            this.lblOUT = new System.Windows.Forms.Label();
            this.lblIN = new System.Windows.Forms.Label();
            this.lblRatioReal = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.picArea = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRatioMonte
            // 
            this.lblRatioMonte.AutoSize = true;
            this.lblRatioMonte.Location = new System.Drawing.Point(618, 159);
            this.lblRatioMonte.Name = "lblRatioMonte";
            this.lblRatioMonte.Size = new System.Drawing.Size(82, 15);
            this.lblRatioMonte.TabIndex = 11;
            this.lblRatioMonte.Text = "RatioMonte";
            // 
            // lblOUT
            // 
            this.lblOUT.AutoSize = true;
            this.lblOUT.Location = new System.Drawing.Point(618, 135);
            this.lblOUT.Name = "lblOUT";
            this.lblOUT.Size = new System.Drawing.Size(37, 15);
            this.lblOUT.TabIndex = 10;
            this.lblOUT.Text = "OUT";
            // 
            // lblIN
            // 
            this.lblIN.AutoSize = true;
            this.lblIN.Location = new System.Drawing.Point(618, 107);
            this.lblIN.Name = "lblIN";
            this.lblIN.Size = new System.Drawing.Size(19, 15);
            this.lblIN.TabIndex = 9;
            this.lblIN.Text = "IN";
            // 
            // lblRatioReal
            // 
            this.lblRatioReal.AutoSize = true;
            this.lblRatioReal.Location = new System.Drawing.Point(618, 77);
            this.lblRatioReal.Name = "lblRatioReal";
            this.lblRatioReal.Size = new System.Drawing.Size(70, 15);
            this.lblRatioReal.TabIndex = 8;
            this.lblRatioReal.Text = "RatioReal";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(618, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(93, 62);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // picArea
            // 
            this.picArea.Location = new System.Drawing.Point(12, 12);
            this.picArea.Name = "picArea";
            this.picArea.Size = new System.Drawing.Size(600, 625);
            this.picArea.TabIndex = 6;
            this.picArea.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 673);
            this.Controls.Add(this.lblRatioMonte);
            this.Controls.Add(this.lblOUT);
            this.Controls.Add(this.lblIN);
            this.Controls.Add(this.lblRatioReal);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picArea);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRatioMonte;
        private System.Windows.Forms.Label lblOUT;
        private System.Windows.Forms.Label lblIN;
        private System.Windows.Forms.Label lblRatioReal;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox picArea;
    }
}

