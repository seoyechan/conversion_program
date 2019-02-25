namespace 문자변환기
{
    partial class conversion
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.BeforeText = new System.Windows.Forms.TextBox();
            this.Before = new System.Windows.Forms.TextBox();
            this.After = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ConversionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BeforeText
            // 
            this.BeforeText.Location = new System.Drawing.Point(13, 13);
            this.BeforeText.Multiline = true;
            this.BeforeText.Name = "BeforeText";
            this.BeforeText.Size = new System.Drawing.Size(275, 476);
            this.BeforeText.TabIndex = 0;
            // 
            // Before
            // 
            this.Before.Location = new System.Drawing.Point(365, 106);
            this.Before.Multiline = true;
            this.Before.Name = "Before";
            this.Before.Size = new System.Drawing.Size(131, 30);
            this.Before.TabIndex = 1;
            // 
            // After
            // 
            this.After.Location = new System.Drawing.Point(366, 157);
            this.After.Multiline = true;
            this.After.Name = "After";
            this.After.Size = new System.Drawing.Size(131, 30);
            this.After.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(528, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 476);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Before :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "After :";
            // 
            // ConversionButton
            // 
            this.ConversionButton.Location = new System.Drawing.Point(350, 416);
            this.ConversionButton.Name = "ConversionButton";
            this.ConversionButton.Size = new System.Drawing.Size(128, 72);
            this.ConversionButton.TabIndex = 6;
            this.ConversionButton.Text = "변환";
            this.ConversionButton.UseVisualStyleBackColor = true;
            this.ConversionButton.Click += new System.EventHandler(this.ConversionButton_Click);
            // 
            // conversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 510);
            this.Controls.Add(this.ConversionButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.After);
            this.Controls.Add(this.Before);
            this.Controls.Add(this.BeforeText);
            this.Name = "conversion";
            this.Text = "conversion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BeforeText;
        private System.Windows.Forms.TextBox Before;
        private System.Windows.Forms.TextBox After;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ConversionButton;
    }
}

