namespace shoppindcart
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
            chbCoffee = new CheckBox();
            button1 = new Button();
            tbCoffeePrice = new TextBox();
            chbGreenTea = new CheckBox();
            tbGreenTeaPrice = new TextBox();
            tbCoffeeQuantity = new TextBox();
            tbGreenTeaQuantity = new TextBox();
            label1 = new Label();
            tbTotal = new TextBox();
            tbcash = new Label();
            textBox1 = new TextBox();
            tbchange = new Label();
            textBox2 = new TextBox();
            tb1000 = new Label();
            tb500 = new Label();
            tb100 = new Label();
            tb50 = new Label();
            tb20 = new Label();
            tb10 = new Label();
            tb5 = new Label();
            tb1 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(24, 50);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(61, 19);
            chbCoffee.TabIndex = 0;
            chbCoffee.Text = "Coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            chbCoffee.CheckedChanged += chbCoffee_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(216, 104);
            button1.Name = "button1";
            button1.Size = new Size(99, 132);
            button1.TabIndex = 1;
            button1.Text = "Checkout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(109, 46);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(100, 23);
            tbCoffeePrice.TabIndex = 2;
            tbCoffeePrice.TextChanged += tbCoffeePrice_TextChanged;
            // 
            // chbGreenTea
            // 
            chbGreenTea.AutoSize = true;
            chbGreenTea.Location = new Point(24, 75);
            chbGreenTea.Name = "chbGreenTea";
            chbGreenTea.Size = new Size(74, 19);
            chbGreenTea.TabIndex = 3;
            chbGreenTea.Text = "GreenTea";
            chbGreenTea.UseVisualStyleBackColor = true;
            chbGreenTea.CheckedChanged += chbGreenTea_CheckedChanged;
            // 
            // tbGreenTeaPrice
            // 
            tbGreenTeaPrice.Location = new Point(109, 75);
            tbGreenTeaPrice.Name = "tbGreenTeaPrice";
            tbGreenTeaPrice.Size = new Size(100, 23);
            tbGreenTeaPrice.TabIndex = 4;
            tbGreenTeaPrice.TextChanged += tbGreenTeaPrice_TextChanged;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(216, 46);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(100, 23);
            tbCoffeeQuantity.TabIndex = 5;
            tbCoffeeQuantity.TextChanged += tbCoffeeQuanity_TextChanged;
            // 
            // tbGreenTeaQuantity
            // 
            tbGreenTeaQuantity.Location = new Point(216, 75);
            tbGreenTeaQuantity.Name = "tbGreenTeaQuantity";
            tbGreenTeaQuantity.Size = new Size(100, 23);
            tbGreenTeaQuantity.TabIndex = 6;
            tbGreenTeaQuantity.TextChanged += tbGreenTeaQuanity_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 117);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 7;
            label1.Text = "Total";
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(77, 114);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(100, 23);
            tbTotal.TabIndex = 8;
            tbTotal.TextChanged += tbTotal_TextChanged;
            // 
            // tbcash
            // 
            tbcash.AutoSize = true;
            tbcash.Location = new Point(24, 146);
            tbcash.Name = "tbcash";
            tbcash.Size = new Size(33, 15);
            tbcash.TabIndex = 9;
            tbcash.Text = "Cash";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // tbchange
            // 
            tbchange.AutoSize = true;
            tbchange.Location = new Point(23, 175);
            tbchange.Name = "tbchange";
            tbchange.Size = new Size(48, 15);
            tbchange.TabIndex = 11;
            tbchange.Text = "Change";
            tbchange.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(77, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            // 
            // tb1000
            // 
            tb1000.AutoSize = true;
            tb1000.Location = new Point(31, 206);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(31, 15);
            tb1000.TabIndex = 13;
            tb1000.Text = "1000";
            tb1000.Click += label4_Click;
            // 
            // tb500
            // 
            tb500.AutoSize = true;
            tb500.Location = new Point(31, 239);
            tb500.Name = "tb500";
            tb500.Size = new Size(25, 15);
            tb500.TabIndex = 14;
            tb500.Text = "500";
            tb500.Click += label5_Click;
            // 
            // tb100
            // 
            tb100.AutoSize = true;
            tb100.Location = new Point(31, 270);
            tb100.Name = "tb100";
            tb100.Size = new Size(25, 15);
            tb100.TabIndex = 15;
            tb100.Text = "100";
            tb100.Click += label6_Click;
            // 
            // tb50
            // 
            tb50.AutoSize = true;
            tb50.Location = new Point(31, 299);
            tb50.Name = "tb50";
            tb50.Size = new Size(19, 15);
            tb50.TabIndex = 16;
            tb50.Text = "50";
            // 
            // tb20
            // 
            tb20.AutoSize = true;
            tb20.Location = new Point(31, 328);
            tb20.Name = "tb20";
            tb20.Size = new Size(19, 15);
            tb20.TabIndex = 17;
            tb20.Text = "20";
            // 
            // tb10
            // 
            tb10.AutoSize = true;
            tb10.Location = new Point(31, 357);
            tb10.Name = "tb10";
            tb10.Size = new Size(19, 15);
            tb10.TabIndex = 18;
            tb10.Text = "10";
            // 
            // tb5
            // 
            tb5.AutoSize = true;
            tb5.Location = new Point(31, 389);
            tb5.Name = "tb5";
            tb5.Size = new Size(13, 15);
            tb5.TabIndex = 19;
            tb5.Text = "5";
            // 
            // tb1
            // 
            tb1.AutoSize = true;
            tb1.Location = new Point(31, 415);
            tb1.Name = "tb1";
            tb1.Size = new Size(13, 15);
            tb1.TabIndex = 20;
            tb1.Text = "1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(77, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 21;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(77, 236);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 22;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(77, 270);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(77, 299);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 24;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(77, 328);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 25;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(77, 357);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 26;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(77, 386);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 27;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(77, 415);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(100, 23);
            textBox10.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 28);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 29;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(238, 28);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 30;
            label3.Text = "Quantity";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(516, 616);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb500);
            Controls.Add(tb1000);
            Controls.Add(textBox2);
            Controls.Add(tbchange);
            Controls.Add(textBox1);
            Controls.Add(tbcash);
            Controls.Add(tbTotal);
            Controls.Add(label1);
            Controls.Add(tbGreenTeaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(tbGreenTeaPrice);
            Controls.Add(chbGreenTea);
            Controls.Add(tbCoffeePrice);
            Controls.Add(button1);
            Controls.Add(chbCoffee);
            Name = "Form1";
            Text = "POS";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chbCoffee;
        private Button button1;
        private TextBox tbCoffeePrice;
        private CheckBox chbGreenTea;
        private TextBox tbGreenTeaPrice;
        private TextBox tbCoffeeQuantity;
        private TextBox tbGreenTeaQuantity;
        private Label label1;
        private TextBox tbTotal;
        private Label tbcash;
        private TextBox textBox1;
        private Label tbchange;
        private TextBox textBox2;
        private Label tb1000;
        private Label tb500;
        private Label tb100;
        private Label tb50;
        private Label tb20;
        private Label tb10;
        private Label tb5;
        private Label tb1;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private Label label2;
        private Label label3;
    }
}
