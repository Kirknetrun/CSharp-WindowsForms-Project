
namespace proj
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
            this.textBoxLitry = new System.Windows.Forms.TextBox();
            this.textBoxKilometry = new System.Windows.Forms.TextBox();
            this.buttonOblicz = new System.Windows.Forms.Button();
            this.labelWynik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWynik2 = new System.Windows.Forms.Label();
            this.labelWynik3 = new System.Windows.Forms.Label();
            this.btnKoniec = new System.Windows.Forms.Button();
            this.textBoxCenaZaLitr = new System.Windows.Forms.TextBox();
            this.buttonWyczysc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLitry
            // 
            this.textBoxLitry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxLitry.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBoxLitry.Location = new System.Drawing.Point(205, 28);
            this.textBoxLitry.Name = "textBoxLitry";
            this.textBoxLitry.Size = new System.Drawing.Size(100, 23);
            this.textBoxLitry.TabIndex = 0;
            // 
            // textBoxKilometry
            // 
            this.textBoxKilometry.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxKilometry.Location = new System.Drawing.Point(205, 88);
            this.textBoxKilometry.Name = "textBoxKilometry";
            this.textBoxKilometry.Size = new System.Drawing.Size(100, 23);
            this.textBoxKilometry.TabIndex = 1;
            // 
            // buttonOblicz
            // 
            this.buttonOblicz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonOblicz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOblicz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonOblicz.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOblicz.Location = new System.Drawing.Point(12, 349);
            this.buttonOblicz.Name = "buttonOblicz";
            this.buttonOblicz.Size = new System.Drawing.Size(148, 73);
            this.buttonOblicz.TabIndex = 3;
            this.buttonOblicz.Text = "Oblicz średnie spalanie";
            this.buttonOblicz.UseVisualStyleBackColor = false;
            this.buttonOblicz.Click += new System.EventHandler(this.buttonOblicz_Click);
            // 
            // labelWynik
            // 
            this.labelWynik.AutoSize = true;
            this.labelWynik.BackColor = System.Drawing.Color.Transparent;
            this.labelWynik.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWynik.Location = new System.Drawing.Point(527, 28);
            this.labelWynik.Name = "labelWynik";
            this.labelWynik.Size = new System.Drawing.Size(88, 15);
            this.labelWynik.TabIndex = 4;
            this.labelWynik.Text = "Wynik: ________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ilość paliwa(pełny bak)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 42);
            this.label2.TabIndex = 6;
            this.label2.Text = "ilość przejechanych \r\nkilometrów\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "cena paliwa za litr";
            // 
            // labelWynik2
            // 
            this.labelWynik2.AutoSize = true;
            this.labelWynik2.BackColor = System.Drawing.Color.Transparent;
            this.labelWynik2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWynik2.Location = new System.Drawing.Point(527, 93);
            this.labelWynik2.Name = "labelWynik2";
            this.labelWynik2.Size = new System.Drawing.Size(90, 15);
            this.labelWynik2.TabIndex = 11;
            this.labelWynik2.Text = "Cena: __________";
            // 
            // labelWynik3
            // 
            this.labelWynik3.AutoSize = true;
            this.labelWynik3.BackColor = System.Drawing.Color.Transparent;
            this.labelWynik3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWynik3.Location = new System.Drawing.Point(527, 160);
            this.labelWynik3.Name = "labelWynik3";
            this.labelWynik3.Size = new System.Drawing.Size(91, 15);
            this.labelWynik3.TabIndex = 12;
            this.labelWynik3.Text = "Cała trasa: _____";
            // 
            // btnKoniec
            // 
            this.btnKoniec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnKoniec.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKoniec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKoniec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKoniec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKoniec.Location = new System.Drawing.Point(686, 399);
            this.btnKoniec.Name = "btnKoniec";
            this.btnKoniec.Size = new System.Drawing.Size(75, 23);
            this.btnKoniec.TabIndex = 13;
            this.btnKoniec.Text = "zakończ";
            this.btnKoniec.UseVisualStyleBackColor = false;
            this.btnKoniec.Click += new System.EventHandler(this.btnKoniec_Click);
            // 
            // textBoxCenaZaLitr
            // 
            this.textBoxCenaZaLitr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxCenaZaLitr.ForeColor = System.Drawing.Color.Black;
            this.textBoxCenaZaLitr.Location = new System.Drawing.Point(205, 152);
            this.textBoxCenaZaLitr.Name = "textBoxCenaZaLitr";
            this.textBoxCenaZaLitr.Size = new System.Drawing.Size(100, 23);
            this.textBoxCenaZaLitr.TabIndex = 14;
            // 
            // buttonWyczysc
            // 
            this.buttonWyczysc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonWyczysc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWyczysc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonWyczysc.Location = new System.Drawing.Point(686, 349);
            this.buttonWyczysc.Name = "buttonWyczysc";
            this.buttonWyczysc.Size = new System.Drawing.Size(75, 23);
            this.buttonWyczysc.TabIndex = 15;
            this.buttonWyczysc.Text = "Wyczyść";
            this.buttonWyczysc.UseVisualStyleBackColor = false;
            this.buttonWyczysc.Click += new System.EventHandler(this.buttonWyczysc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(311, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "(L)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(311, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "(Km)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(312, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "(zł)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(220, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "(wymagane)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(220, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "(wymagane)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(219, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 15);
            this.label9.TabIndex = 21;
            this.label9.Text = "(opcjonalne)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            //
            this.ClientSize = new System.Drawing.Size(805, 453);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonWyczysc);
            this.Controls.Add(this.textBoxCenaZaLitr);
            this.Controls.Add(this.btnKoniec);
            this.Controls.Add(this.labelWynik3);
            this.Controls.Add(this.labelWynik2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelWynik);
            this.Controls.Add(this.buttonOblicz);
            this.Controls.Add(this.textBoxKilometry);
            this.Controls.Add(this.textBoxLitry);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Kalkulator średniego spalania paliwa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLitry;
        private System.Windows.Forms.TextBox textBoxKilometry;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button buttonOblicz;
        private System.Windows.Forms.Label labelWynik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWynik2;
        private System.Windows.Forms.Label labelWynik3;
        private System.Windows.Forms.Button btnKoniec;
        private System.Windows.Forms.TextBox textBoxCenaZaLitr;
        private System.Windows.Forms.Button buttonWyczysc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

