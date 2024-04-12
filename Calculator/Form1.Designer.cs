namespace Calculator
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.ButtonMultiple = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonAC = new System.Windows.Forms.Button();
            this.Button0 = new System.Windows.Forms.Button();
            this.ButtonPoint = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.BtnResult = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Dock = System.Windows.Forms.DockStyle.Top;
            this.display.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.display.Location = new System.Drawing.Point(0, 0);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(810, 67);
            this.display.TabIndex = 0;
            this.display.Text = "0";
            this.display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ButtonPoint, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Button0, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonAC, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMinus, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ButtonMultiple, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Button4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButtonDivide, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button9, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button8, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Button7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ButtonPlus, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 364);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Button9
            // 
            this.Button9.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button9.Location = new System.Drawing.Point(405, 3);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(195, 85);
            this.Button9.TabIndex = 2;
            this.Button9.Text = "9";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button8
            // 
            this.Button8.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button8.Location = new System.Drawing.Point(204, 3);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(195, 85);
            this.Button8.TabIndex = 1;
            this.Button8.Text = "8";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button7.Location = new System.Drawing.Point(3, 3);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(195, 85);
            this.Button7.TabIndex = 0;
            this.Button7.Text = "7";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonDivide.Location = new System.Drawing.Point(606, 3);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(195, 85);
            this.ButtonDivide.TabIndex = 3;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.ButtonDivide_Click);
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button4.Location = new System.Drawing.Point(3, 94);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(195, 85);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "4";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button5.Location = new System.Drawing.Point(204, 94);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(195, 85);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "5";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button6.Location = new System.Drawing.Point(405, 94);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(195, 85);
            this.Button6.TabIndex = 6;
            this.Button6.Text = "6";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // ButtonMultiple
            // 
            this.ButtonMultiple.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonMultiple.Location = new System.Drawing.Point(606, 94);
            this.ButtonMultiple.Name = "ButtonMultiple";
            this.ButtonMultiple.Size = new System.Drawing.Size(195, 85);
            this.ButtonMultiple.TabIndex = 7;
            this.ButtonMultiple.Text = "X";
            this.ButtonMultiple.UseVisualStyleBackColor = true;
            this.ButtonMultiple.Click += new System.EventHandler(this.ButtonMultiple_Click);
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button1.Location = new System.Drawing.Point(3, 185);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(195, 85);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button2.Location = new System.Drawing.Point(204, 185);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(195, 85);
            this.Button2.TabIndex = 9;
            this.Button2.Text = "2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button3.Location = new System.Drawing.Point(405, 185);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(195, 85);
            this.Button3.TabIndex = 10;
            this.Button3.Text = "3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonMinus.Location = new System.Drawing.Point(606, 185);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(195, 85);
            this.ButtonMinus.TabIndex = 11;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonAC
            // 
            this.ButtonAC.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonAC.Location = new System.Drawing.Point(3, 276);
            this.ButtonAC.Name = "ButtonAC";
            this.ButtonAC.Size = new System.Drawing.Size(195, 85);
            this.ButtonAC.TabIndex = 12;
            this.ButtonAC.Text = "AC";
            this.ButtonAC.UseVisualStyleBackColor = true;
            this.ButtonAC.Click += new System.EventHandler(this.ButtonAC_Click);
            // 
            // Button0
            // 
            this.Button0.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Button0.Location = new System.Drawing.Point(204, 276);
            this.Button0.Name = "Button0";
            this.Button0.Size = new System.Drawing.Size(195, 85);
            this.Button0.TabIndex = 13;
            this.Button0.Text = "0";
            this.Button0.UseVisualStyleBackColor = true;
            this.Button0.Click += new System.EventHandler(this.Button0_Click);
            // 
            // ButtonPoint
            // 
            this.ButtonPoint.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonPoint.Location = new System.Drawing.Point(405, 276);
            this.ButtonPoint.Name = "ButtonPoint";
            this.ButtonPoint.Size = new System.Drawing.Size(195, 85);
            this.ButtonPoint.TabIndex = 14;
            this.ButtonPoint.Text = ".";
            this.ButtonPoint.UseVisualStyleBackColor = true;
            this.ButtonPoint.Click += new System.EventHandler(this.ButtonPoint_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ButtonPlus.Location = new System.Drawing.Point(606, 276);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(195, 85);
            this.ButtonPlus.TabIndex = 15;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // BtnResult
            // 
            this.BtnResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnResult.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BtnResult.Location = new System.Drawing.Point(0, 435);
            this.BtnResult.Name = "BtnResult";
            this.BtnResult.Size = new System.Drawing.Size(810, 64);
            this.BtnResult.TabIndex = 2;
            this.BtnResult.Text = "=";
            this.BtnResult.UseVisualStyleBackColor = true;
            this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 499);
            this.Controls.Add(this.BtnResult);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "계산기";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label display;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button ButtonPoint;
        private System.Windows.Forms.Button Button0;
        private System.Windows.Forms.Button ButtonAC;
        private System.Windows.Forms.Button ButtonMinus;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button ButtonMultiple;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonPlus;
        private System.Windows.Forms.Button BtnResult;
    }
}

