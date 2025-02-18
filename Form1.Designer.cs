namespace L1 {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel1 = new Panel();
            mirrorYBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            YOffset = new NumericUpDown();
            XOffset = new NumericUpDown();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)YOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)XOffset).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Font = new Font("Segoe UI", 15F);
            numericUpDown1.Location = new Point(171, 9);
            numericUpDown1.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 34);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Font = new Font("Segoe UI", 15F);
            numericUpDown2.Location = new Point(171, 48);
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 34);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(191, 94);
            button1.Name = "button1";
            button1.Size = new Size(49, 38);
            button1.TabIndex = 4;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += quart2Btn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(297, 94);
            button2.Name = "button2";
            button2.Size = new Size(49, 38);
            button2.TabIndex = 5;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += quart1Btn_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(298, 171);
            button3.Name = "button3";
            button3.Size = new Size(49, 38);
            button3.TabIndex = 7;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += quart4Btn_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(190, 171);
            button4.Name = "button4";
            button4.Size = new Size(49, 38);
            button4.TabIndex = 6;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += quart3Btn_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15F);
            button5.Location = new Point(244, 131);
            button5.Name = "button5";
            button5.Size = new Size(49, 38);
            button5.TabIndex = 8;
            button5.Text = "0";
            button5.UseVisualStyleBackColor = true;
            button5.Click += centerBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.Controls.Add(mirrorYBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(YOffset);
            panel1.Controls.Add(XOffset);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numericUpDown2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(numericUpDown1);
            panel1.Location = new Point(1445, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(447, 415);
            panel1.TabIndex = 9;
            // 
            // mirrorYBtn
            // 
            mirrorYBtn.Font = new Font("Segoe UI", 15F);
            mirrorYBtn.Location = new Point(171, 326);
            mirrorYBtn.Name = "mirrorYBtn";
            mirrorYBtn.Size = new Size(143, 68);
            mirrorYBtn.TabIndex = 16;
            mirrorYBtn.Text = "Отражение";
            mirrorYBtn.UseVisualStyleBackColor = true;
            mirrorYBtn.Click += mirrorYBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(15, 284);
            label2.Name = "label2";
            label2.Size = new Size(111, 28);
            label2.TabIndex = 15;
            label2.Text = "Сдвиг по Y";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(15, 246);
            label1.Name = "label1";
            label1.Size = new Size(112, 28);
            label1.TabIndex = 14;
            label1.Text = "Сдвиг по Х";
            // 
            // YOffset
            // 
            YOffset.Font = new Font("Segoe UI", 15F);
            YOffset.Location = new Point(173, 282);
            YOffset.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            YOffset.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            YOffset.Name = "YOffset";
            YOffset.Size = new Size(120, 34);
            YOffset.TabIndex = 13;
            YOffset.ValueChanged += YOffset_ValueChanged;
            // 
            // XOffset
            // 
            XOffset.Font = new Font("Segoe UI", 15F);
            XOffset.Location = new Point(173, 244);
            XOffset.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            XOffset.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            XOffset.Name = "XOffset";
            XOffset.Size = new Size(120, 34);
            XOffset.TabIndex = 12;
            XOffset.ValueChanged += XOffset_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(8, 128);
            label5.Name = "label5";
            label5.Size = new Size(153, 28);
            label5.TabIndex = 11;
            label5.Text = "Расположение ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(8, 52);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 10;
            label4.Text = "Масштаб";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(7, 13);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 9;
            label3.Text = "Угол поворота";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)YOffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)XOffset).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private NumericUpDown YOffset;
        private NumericUpDown XOffset;
        private Button mirrorYBtn;
    }
}
