namespace SS3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button00 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.dataGridViewWinners = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWinners)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox.Location = new System.Drawing.Point(14, 15);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(225, 250);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // button00
            // 
            this.button00.Location = new System.Drawing.Point(282, 15);
            this.button00.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(75, 78);
            this.button00.TabIndex = 1;
            this.button00.Text = "0;0";
            this.button00.UseVisualStyleBackColor = true;
            this.button00.Click += new System.EventHandler(this.button00_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(364, 100);
            this.button11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 78);
            this.button11.TabIndex = 2;
            this.button11.Text = "1;1";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(282, 100);
            this.button10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 78);
            this.button10.TabIndex = 3;
            this.button10.Text = "1;0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(364, 15);
            this.button01.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(75, 78);
            this.button01.TabIndex = 4;
            this.button01.Text = "0;1";
            this.button01.UseVisualStyleBackColor = true;
            this.button01.Click += new System.EventHandler(this.button01_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(447, 100);
            this.button12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 78);
            this.button12.TabIndex = 5;
            this.button12.Text = "1;2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(282, 185);
            this.button20.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 78);
            this.button20.TabIndex = 6;
            this.button20.Text = "2;0";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(447, 15);
            this.button02.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(75, 78);
            this.button02.TabIndex = 7;
            this.button02.Text = "0;2";
            this.button02.UseVisualStyleBackColor = true;
            this.button02.Click += new System.EventHandler(this.button02_Click);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(364, 185);
            this.button21.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(75, 78);
            this.button21.TabIndex = 8;
            this.button21.Text = "2;1";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(447, 185);
            this.button22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 78);
            this.button22.TabIndex = 9;
            this.button22.Text = "2;2";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(14, 312);
            this.textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(512, 26);
            this.textBox.TabIndex = 10;
            // 
            // dataGridViewWinners
            // 
            this.dataGridViewWinners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWinners.Location = new System.Drawing.Point(608, 28);
            this.dataGridViewWinners.Name = "dataGridViewWinners";
            this.dataGridViewWinners.RowTemplate.Height = 28;
            this.dataGridViewWinners.Size = new System.Drawing.Size(366, 309);
            this.dataGridViewWinners.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 368);
            this.Controls.Add(this.dataGridViewWinners);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button02);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button01);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button00);
            this.Controls.Add(this.pictureBox);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWinners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.DataGridView dataGridViewWinners;
    }
}

