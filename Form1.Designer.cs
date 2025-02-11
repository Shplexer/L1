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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(110, 9);
            numericUpDown1.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.DecimalPlaces = 2;
            numericUpDown2.Location = new Point(110, 48);
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(120, 23);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(130, 94);
            button1.Name = "button1";
            button1.Size = new Size(28, 23);
            button1.TabIndex = 4;
            button1.Text = "2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += quart2Btn_Click;
            // 
            // button2
            // 
            button2.Location = new Point(202, 94);
            button2.Name = "button2";
            button2.Size = new Size(28, 23);
            button2.TabIndex = 5;
            button2.Text = "1";
            button2.UseVisualStyleBackColor = true;
            button2.Click += quart1Btn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(202, 152);
            button3.Name = "button3";
            button3.Size = new Size(28, 23);
            button3.TabIndex = 7;
            button3.Text = "4";
            button3.UseVisualStyleBackColor = true;
            button3.Click += quart4Btn_Click;
            // 
            // button4
            // 
            button4.Location = new Point(130, 152);
            button4.Name = "button4";
            button4.Size = new Size(28, 23);
            button4.TabIndex = 6;
            button4.Text = "3";
            button4.UseVisualStyleBackColor = true;
            button4.Click += quart3Btn_Click;
            // 
            // button5
            // 
            button5.Location = new Point(169, 124);
            button5.Name = "button5";
            button5.Size = new Size(28, 23);
            button5.TabIndex = 8;
            button5.Text = "0";
            button5.UseVisualStyleBackColor = true;
            button5.Click += centerBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
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
            panel1.Location = new Point(1320, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 184);
            panel1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 128);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 11;
            label5.Text = "Расположение ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 52);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 10;
            label4.Text = "Масштаб";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 13);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 9;
            label3.Text = "Угол поворота";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1573, 983);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
    }
}
