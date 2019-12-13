namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.hex = new System.Windows.Forms.RadioButton();
            this.dec = new System.Windows.Forms.RadioButton();
            this.oct = new System.Windows.Forms.RadioButton();
            this.bin = new System.Windows.Forms.RadioButton();
            this.Tablo = new System.Windows.Forms.TextBox();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.smena = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.BackSpace = new System.Windows.Forms.Button();
            this.mult = new System.Windows.Forms.Button();
            this.min = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(164, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 67;
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.Location = new System.Drawing.Point(255, 125);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(47, 17);
            this.hex.TabIndex = 66;
            this.hex.Text = "HEX";
            this.hex.UseVisualStyleBackColor = true;
            this.hex.CheckedChanged += new System.EventHandler(this.bin_CheckedChanged);
            // 
            // dec
            // 
            this.dec.AutoSize = true;
            this.dec.Location = new System.Drawing.Point(255, 102);
            this.dec.Name = "dec";
            this.dec.Size = new System.Drawing.Size(47, 17);
            this.dec.TabIndex = 65;
            this.dec.Text = "DEC";
            this.dec.UseVisualStyleBackColor = true;
            this.dec.CheckedChanged += new System.EventHandler(this.bin_CheckedChanged);
            // 
            // oct
            // 
            this.oct.AutoSize = true;
            this.oct.Location = new System.Drawing.Point(164, 125);
            this.oct.Name = "oct";
            this.oct.Size = new System.Drawing.Size(47, 17);
            this.oct.TabIndex = 64;
            this.oct.Text = "OCT";
            this.oct.UseVisualStyleBackColor = true;
            this.oct.CheckedChanged += new System.EventHandler(this.bin_CheckedChanged);
            // 
            // bin
            // 
            this.bin.AutoSize = true;
            this.bin.Location = new System.Drawing.Point(164, 102);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(43, 17);
            this.bin.TabIndex = 63;
            this.bin.Text = "BIN";
            this.bin.UseVisualStyleBackColor = true;
            this.bin.CheckedChanged += new System.EventHandler(this.bin_CheckedChanged);
            // 
            // Tablo
            // 
            this.Tablo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.Tablo.Location = new System.Drawing.Point(164, 44);
            this.Tablo.MaxLength = 18;
            this.Tablo.Multiline = true;
            this.Tablo.Name = "Tablo";
            this.Tablo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Tablo.Size = new System.Drawing.Size(475, 52);
            this.Tablo.TabIndex = 62;
            this.Tablo.Text = "0";
            this.Tablo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Tablo.WordWrap = false;
            // 
            // button26
            // 
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button26.Location = new System.Drawing.Point(564, 334);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(75, 47);
            this.button26.TabIndex = 61;
            this.button26.Text = "F";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button1_Click);
            // 
            // button27
            // 
            this.button27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button27.Location = new System.Drawing.Point(483, 334);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(75, 47);
            this.button27.TabIndex = 60;
            this.button27.Text = "E";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button1_Click);
            // 
            // button24
            // 
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button24.Location = new System.Drawing.Point(564, 281);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(75, 47);
            this.button24.TabIndex = 59;
            this.button24.Text = "D";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button1_Click);
            // 
            // button25
            // 
            this.button25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button25.Location = new System.Drawing.Point(483, 281);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(75, 47);
            this.button25.TabIndex = 58;
            this.button25.Text = "C";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button1_Click);
            // 
            // button23
            // 
            this.button23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button23.Location = new System.Drawing.Point(564, 228);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(75, 47);
            this.button23.TabIndex = 57;
            this.button23.Text = "B";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.button1_Click);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button13.Location = new System.Drawing.Point(483, 228);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 47);
            this.button13.TabIndex = 56;
            this.button13.Text = "A";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button1_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.del.Location = new System.Drawing.Point(402, 148);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 47);
            this.del.TabIndex = 55;
            this.del.Text = "/";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.plus_Click);
            // 
            // smena
            // 
            this.smena.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.smena.Location = new System.Drawing.Point(323, 360);
            this.smena.Name = "smena";
            this.smena.Size = new System.Drawing.Size(75, 47);
            this.smena.TabIndex = 54;
            this.smena.Text = "+/-";
            this.smena.UseVisualStyleBackColor = true;
            this.smena.Click += new System.EventHandler(this.smena_Click);
            // 
            // button20
            // 
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button20.Location = new System.Drawing.Point(242, 360);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(75, 47);
            this.button20.TabIndex = 53;
            this.button20.Text = "0";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button1_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dot.Location = new System.Drawing.Point(161, 360);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(75, 47);
            this.dot.TabIndex = 52;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button14.Location = new System.Drawing.Point(564, 175);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 47);
            this.button14.TabIndex = 51;
            this.button14.Text = "E+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button15.Location = new System.Drawing.Point(483, 175);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 47);
            this.button15.TabIndex = 50;
            this.button15.Text = "E-";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.equal.Location = new System.Drawing.Point(402, 307);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 100);
            this.equal.TabIndex = 49;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Clear.Location = new System.Drawing.Point(402, 254);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 47);
            this.Clear.TabIndex = 48;
            this.Clear.Text = "CE";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // BackSpace
            // 
            this.BackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.BackSpace.Location = new System.Drawing.Point(402, 201);
            this.BackSpace.Name = "BackSpace";
            this.BackSpace.Size = new System.Drawing.Size(75, 47);
            this.BackSpace.TabIndex = 47;
            this.BackSpace.Text = "<<";
            this.BackSpace.UseVisualStyleBackColor = true;
            this.BackSpace.Click += new System.EventHandler(this.BackSpace_Click);
            // 
            // mult
            // 
            this.mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.mult.Location = new System.Drawing.Point(323, 148);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(75, 47);
            this.mult.TabIndex = 46;
            this.mult.Text = "*";
            this.mult.UseVisualStyleBackColor = true;
            this.mult.Click += new System.EventHandler(this.plus_Click);
            // 
            // min
            // 
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.min.Location = new System.Drawing.Point(242, 148);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(75, 47);
            this.min.TabIndex = 45;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = true;
            this.min.Click += new System.EventHandler(this.plus_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.plus.Location = new System.Drawing.Point(161, 148);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(75, 47);
            this.plus.TabIndex = 44;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button10.Location = new System.Drawing.Point(321, 307);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 47);
            this.button10.TabIndex = 43;
            this.button10.Text = "3";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button1_Click);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button11.Location = new System.Drawing.Point(321, 254);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 47);
            this.button11.TabIndex = 42;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button1_Click);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button12.Location = new System.Drawing.Point(321, 201);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 47);
            this.button12.TabIndex = 41;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button1_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button6.Location = new System.Drawing.Point(242, 307);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 47);
            this.button6.TabIndex = 40;
            this.button6.Text = "2";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button5.Location = new System.Drawing.Point(242, 254);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 47);
            this.button5.TabIndex = 39;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button4.Location = new System.Drawing.Point(242, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 47);
            this.button4.TabIndex = 38;
            this.button4.Text = "8";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button3.Location = new System.Drawing.Point(161, 307);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 47);
            this.button3.TabIndex = 37;
            this.button3.Text = "1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button2.Location = new System.Drawing.Point(161, 254);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 36;
            this.button2.Text = "4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(161, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 35;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hex);
            this.Controls.Add(this.dec);
            this.Controls.Add(this.oct);
            this.Controls.Add(this.bin);
            this.Controls.Add(this.Tablo);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.del);
            this.Controls.Add(this.smena);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BackSpace);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.min);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Системный калькулятор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton hex;
        private System.Windows.Forms.RadioButton dec;
        private System.Windows.Forms.RadioButton oct;
        private System.Windows.Forms.RadioButton bin;
        private System.Windows.Forms.TextBox Tablo;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button smena;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button BackSpace;
        private System.Windows.Forms.Button mult;
        private System.Windows.Forms.Button min;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

