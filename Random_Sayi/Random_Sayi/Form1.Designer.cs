namespace Random_Sayi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(10, 308);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(135, 33);
            button1.TabIndex = 0;
            button1.Text = "ÜRET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Uret_Click;
            // 
            // button2
            // 
            button2.Location = new Point(179, 308);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(135, 33);
            button2.TabIndex = 1;
            button2.Text = "KOPYALA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Kopyala_Click;
            // 
            // button3
            // 
            button3.Location = new Point(94, 345);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(135, 33);
            button3.TabIndex = 2;
            button3.Text = "TEMİZLE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Temizle_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(10, 245);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(303, 46);
            listBox1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 193);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 29);
            textBox1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 161);
            label1.Name = "label1";
            label1.Size = new Size(268, 21);
            label1.TabIndex = 5;
            label1.Text = "Sayıların Başına Gelecek Kelimeyi Yaz";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 19);
            label2.Name = "label2";
            label2.Size = new Size(107, 21);
            label2.TabIndex = 6;
            label2.Text = "1.Sayı Aralığı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 71);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 7;
            label3.Text = "2.Sayı Aralığı :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 124);
            label4.Name = "label4";
            label4.Size = new Size(107, 21);
            label4.TabIndex = 8;
            label4.Text = "3.Sayı Aralığı :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 14);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(75, 29);
            textBox2.TabIndex = 9;
            textBox2.KeyPress += SadeceSayi_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(235, 14);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(75, 29);
            textBox3.TabIndex = 10;
            textBox3.KeyPress += SadeceSayi_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 67);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(75, 29);
            textBox4.TabIndex = 11;
            textBox4.KeyPress += SadeceSayi_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(235, 67);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(75, 29);
            textBox5.TabIndex = 12;
            textBox5.KeyPress += SadeceSayi_KeyPress;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(134, 119);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(75, 29);
            textBox6.TabIndex = 13;
            textBox6.KeyPress += SadeceSayi_KeyPress;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(235, 119);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(75, 29);
            textBox7.TabIndex = 14;
            textBox7.KeyPress += SadeceSayi_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(213, 19);
            label5.Name = "label5";
            label5.Size = new Size(16, 21);
            label5.TabIndex = 15;
            label5.Text = "-";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 71);
            label6.Name = "label6";
            label6.Size = new Size(16, 21);
            label6.TabIndex = 16;
            label6.Text = "-";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 124);
            label7.Name = "label7";
            label7.Size = new Size(16, 21);
            label7.TabIndex = 17;
            label7.Text = "-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(325, 386);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Sayı Üretici";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}