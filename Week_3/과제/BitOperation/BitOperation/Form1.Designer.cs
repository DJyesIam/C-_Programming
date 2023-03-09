namespace BitOperation
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnToBit = new System.Windows.Forms.Button();
            this.btnFromBit = new System.Windows.Forms.Button();
            this.btnOn = new System.Windows.Forms.Button();
            this.btnOff = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnShiftUp = new System.Windows.Forms.Button();
            this.btnShiftDown = new System.Windows.Forms.Button();
            this.chk0 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.BitsCheckBox = new System.Windows.Forms.GroupBox();
            this.BitsCheckBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(25, 34);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(119, 25);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.Text = "0";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(25, 143);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(119, 25);
            this.txtIndex.TabIndex = 1;
            this.txtIndex.Text = "0";
            // 
            // btnToBit
            // 
            this.btnToBit.Location = new System.Drawing.Point(184, 34);
            this.btnToBit.Name = "btnToBit";
            this.btnToBit.Size = new System.Drawing.Size(84, 40);
            this.btnToBit.TabIndex = 2;
            this.btnToBit.Text = ">>";
            this.btnToBit.UseVisualStyleBackColor = true;
            this.btnToBit.Click += new System.EventHandler(this.btnToBit_Click);
            // 
            // btnFromBit
            // 
            this.btnFromBit.Location = new System.Drawing.Point(184, 80);
            this.btnFromBit.Name = "btnFromBit";
            this.btnFromBit.Size = new System.Drawing.Size(84, 40);
            this.btnFromBit.TabIndex = 3;
            this.btnFromBit.Text = "<<";
            this.btnFromBit.UseVisualStyleBackColor = true;
            this.btnFromBit.Click += new System.EventHandler(this.btnFromBit_Click);
            // 
            // btnOn
            // 
            this.btnOn.Location = new System.Drawing.Point(184, 143);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(84, 40);
            this.btnOn.TabIndex = 4;
            this.btnOn.Text = "ON";
            this.btnOn.UseVisualStyleBackColor = true;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // btnOff
            // 
            this.btnOff.Location = new System.Drawing.Point(184, 189);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(84, 40);
            this.btnOff.TabIndex = 5;
            this.btnOff.Text = "OFF";
            this.btnOff.UseVisualStyleBackColor = true;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Location = new System.Drawing.Point(184, 235);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(84, 40);
            this.btnToggle.TabIndex = 6;
            this.btnToggle.Text = "Toggle";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnShiftUp
            // 
            this.btnShiftUp.Location = new System.Drawing.Point(25, 321);
            this.btnShiftUp.Name = "btnShiftUp";
            this.btnShiftUp.Size = new System.Drawing.Size(111, 40);
            this.btnShiftUp.TabIndex = 7;
            this.btnShiftUp.Text = "ShiftUp";
            this.btnShiftUp.UseVisualStyleBackColor = true;
            this.btnShiftUp.Click += new System.EventHandler(this.btnShiftUp_Click);
            // 
            // btnShiftDown
            // 
            this.btnShiftDown.Location = new System.Drawing.Point(157, 321);
            this.btnShiftDown.Name = "btnShiftDown";
            this.btnShiftDown.Size = new System.Drawing.Size(111, 40);
            this.btnShiftDown.TabIndex = 9;
            this.btnShiftDown.Text = "ShiftDown";
            this.btnShiftDown.UseVisualStyleBackColor = true;
            this.btnShiftDown.Click += new System.EventHandler(this.btnShiftDown_Click);
            // 
            // chk0
            // 
            this.chk0.AutoSize = true;
            this.chk0.Location = new System.Drawing.Point(32, 330);
            this.chk0.Name = "chk0";
            this.chk0.Size = new System.Drawing.Size(37, 19);
            this.chk0.TabIndex = 10;
            this.chk0.Text = "0";
            this.chk0.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Location = new System.Drawing.Point(32, 289);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(37, 19);
            this.chk1.TabIndex = 11;
            this.chk1.Text = "1";
            this.chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(32, 244);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(37, 19);
            this.chk2.TabIndex = 12;
            this.chk2.Text = "2";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.Location = new System.Drawing.Point(32, 198);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(37, 19);
            this.chk3.TabIndex = 13;
            this.chk3.Text = "3";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(32, 152);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(37, 19);
            this.chk4.TabIndex = 14;
            this.chk4.Text = "4";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(32, 109);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(37, 19);
            this.chk5.TabIndex = 15;
            this.chk5.Text = "5";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(32, 68);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(37, 19);
            this.chk6.TabIndex = 16;
            this.chk6.Text = "6";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(32, 24);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(37, 19);
            this.chk7.TabIndex = 17;
            this.chk7.Text = "7";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // BitsCheckBox
            // 
            this.BitsCheckBox.Controls.Add(this.chk7);
            this.BitsCheckBox.Controls.Add(this.chk6);
            this.BitsCheckBox.Controls.Add(this.chk5);
            this.BitsCheckBox.Controls.Add(this.chk4);
            this.BitsCheckBox.Controls.Add(this.chk3);
            this.BitsCheckBox.Controls.Add(this.chk2);
            this.BitsCheckBox.Controls.Add(this.chk1);
            this.BitsCheckBox.Controls.Add(this.chk0);
            this.BitsCheckBox.Location = new System.Drawing.Point(274, 12);
            this.BitsCheckBox.Name = "BitsCheckBox";
            this.BitsCheckBox.Size = new System.Drawing.Size(102, 364);
            this.BitsCheckBox.TabIndex = 18;
            this.BitsCheckBox.TabStop = false;
            this.BitsCheckBox.Text = "Bits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 414);
            this.Controls.Add(this.BitsCheckBox);
            this.Controls.Add(this.btnShiftDown);
            this.Controls.Add(this.btnShiftUp);
            this.Controls.Add(this.btnToggle);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.btnFromBit);
            this.Controls.Add(this.btnToBit);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.txtNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BitsCheckBox.ResumeLayout(false);
            this.BitsCheckBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnToBit;
        private System.Windows.Forms.Button btnFromBit;
        private System.Windows.Forms.Button btnOn;
        private System.Windows.Forms.Button btnOff;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnShiftUp;
        private System.Windows.Forms.Button btnShiftDown;
        private System.Windows.Forms.CheckBox chk0;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.GroupBox BitsCheckBox;
    }
}

