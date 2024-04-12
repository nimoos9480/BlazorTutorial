namespace FindNumber
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
            this.display = new System.Windows.Forms.Label();
            this.ButtonInput = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.hint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(800, 52);
            this.display.TabIndex = 0;
            this.display.Text = "게임을 시작합니다.";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonInput
            // 
            this.ButtonInput.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonInput.Location = new System.Drawing.Point(424, 86);
            this.ButtonInput.Name = "ButtonInput";
            this.ButtonInput.Size = new System.Drawing.Size(189, 46);
            this.ButtonInput.TabIndex = 1;
            this.ButtonInput.Text = "입력";
            this.ButtonInput.UseVisualStyleBackColor = true;
            this.ButtonInput.Click += new System.EventHandler(this.ButtonInput_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox.Location = new System.Drawing.Point(177, 86);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(223, 39);
            this.textBox.TabIndex = 2;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtonStart.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonStart.Location = new System.Drawing.Point(0, 384);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(800, 66);
            this.ButtonStart.TabIndex = 3;
            this.ButtonStart.Text = "게임 시작";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // hint
            // 
            this.hint.AutoSize = true;
            this.hint.Location = new System.Drawing.Point(351, 151);
            this.hint.Name = "hint";
            this.hint.Size = new System.Drawing.Size(46, 19);
            this.hint.TabIndex = 4;
            this.hint.Text = "힌트";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hint);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.ButtonInput);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.Button ButtonInput;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Label hint;
    }
}

