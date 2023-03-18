namespace MoleGame
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
            this.lblScore = new System.Windows.Forms.Label();
            this.timOpen = new System.Windows.Forms.Timer(this.components);
            this.timClose = new System.Windows.Forms.Timer(this.components);
            this.pickCard04 = new System.Windows.Forms.PictureBox();
            this.pickCard03 = new System.Windows.Forms.PictureBox();
            this.pickCard02 = new System.Windows.Forms.PictureBox();
            this.pickCard01 = new System.Windows.Forms.PictureBox();
            this.pickCard00 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard00)).BeginInit();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("궁서체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblScore.Location = new System.Drawing.Point(263, 23);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(29, 30);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "0";
            // 
            // timOpen
            // 
            this.timOpen.Enabled = true;
            this.timOpen.Interval = 1000;
            this.timOpen.Tick += new System.EventHandler(this.timOpen_Tick);
            // 
            // timClose
            // 
            this.timClose.Interval = 700;
            this.timClose.Tick += new System.EventHandler(this.timClose_Tick);
            // 
            // pickCard04
            // 
            this.pickCard04.Image = global::MoleGame.Properties.Resources.closed;
            this.pickCard04.Location = new System.Drawing.Point(477, 117);
            this.pickCard04.Name = "pickCard04";
            this.pickCard04.Size = new System.Drawing.Size(71, 96);
            this.pickCard04.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pickCard04.TabIndex = 4;
            this.pickCard04.TabStop = false;
            this.pickCard04.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pickCard_MouseDown);
            // 
            // pickCard03
            // 
            this.pickCard03.Image = global::MoleGame.Properties.Resources.closed;
            this.pickCard03.Location = new System.Drawing.Point(356, 117);
            this.pickCard03.Name = "pickCard03";
            this.pickCard03.Size = new System.Drawing.Size(71, 96);
            this.pickCard03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pickCard03.TabIndex = 3;
            this.pickCard03.TabStop = false;
            this.pickCard03.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pickCard_MouseDown);
            // 
            // pickCard02
            // 
            this.pickCard02.Image = global::MoleGame.Properties.Resources.closed;
            this.pickCard02.Location = new System.Drawing.Point(240, 117);
            this.pickCard02.Name = "pickCard02";
            this.pickCard02.Size = new System.Drawing.Size(71, 96);
            this.pickCard02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pickCard02.TabIndex = 2;
            this.pickCard02.TabStop = false;
            this.pickCard02.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pickCard_MouseDown);
            // 
            // pickCard01
            // 
            this.pickCard01.Image = global::MoleGame.Properties.Resources.closed;
            this.pickCard01.Location = new System.Drawing.Point(125, 117);
            this.pickCard01.Name = "pickCard01";
            this.pickCard01.Size = new System.Drawing.Size(71, 96);
            this.pickCard01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pickCard01.TabIndex = 1;
            this.pickCard01.TabStop = false;
            this.pickCard01.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pickCard_MouseDown);
            // 
            // pickCard00
            // 
            this.pickCard00.Image = global::MoleGame.Properties.Resources.closed;
            this.pickCard00.Location = new System.Drawing.Point(14, 117);
            this.pickCard00.Name = "pickCard00";
            this.pickCard00.Size = new System.Drawing.Size(71, 96);
            this.pickCard00.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pickCard00.TabIndex = 0;
            this.pickCard00.TabStop = false;
            this.pickCard00.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pickCard_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 269);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pickCard04);
            this.Controls.Add(this.pickCard03);
            this.Controls.Add(this.pickCard02);
            this.Controls.Add(this.pickCard01);
            this.Controls.Add(this.pickCard00);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pickCard04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickCard00)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pickCard00;
        private System.Windows.Forms.PictureBox pickCard01;
        private System.Windows.Forms.PictureBox pickCard02;
        private System.Windows.Forms.PictureBox pickCard03;
        private System.Windows.Forms.PictureBox pickCard04;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer timOpen;
        private System.Windows.Forms.Timer timClose;
    }
}

