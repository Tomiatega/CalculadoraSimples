﻿namespace CalculadoraSimples
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonMenos = new System.Windows.Forms.Button();
            this.buttonDeleta = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.buttonApaga = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.buttonParenteses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDisplay.Location = new System.Drawing.Point(24, 39);
            this.textBoxDisplay.Margin = new System.Windows.Forms.Padding(7);
            this.textBoxDisplay.Multiline = true;
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(305, 91);
            this.textBoxDisplay.TabIndex = 0;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(507, 872);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(7);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(175, 196);
            this.buttonEnter.TabIndex = 1;
            this.buttonEnter.Text = "=";
            this.buttonEnter.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 67);
            this.button1.TabIndex = 2;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(277, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 140);
            this.button2.TabIndex = 3;
            this.button2.Text = "=";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(188, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(79, 67);
            this.button3.TabIndex = 4;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMenos
            // 
            this.buttonMenos.Location = new System.Drawing.Point(98, 140);
            this.buttonMenos.Name = "buttonMenos";
            this.buttonMenos.Size = new System.Drawing.Size(84, 67);
            this.buttonMenos.TabIndex = 5;
            this.buttonMenos.Text = "-";
            this.buttonMenos.UseVisualStyleBackColor = true;
            this.buttonMenos.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonDeleta
            // 
            this.buttonDeleta.Location = new System.Drawing.Point(0, 140);
            this.buttonDeleta.Name = "buttonDeleta";
            this.buttonDeleta.Size = new System.Drawing.Size(94, 67);
            this.buttonDeleta.TabIndex = 6;
            this.buttonDeleta.Text = "CE";
            this.buttonDeleta.UseVisualStyleBackColor = true;
            this.buttonDeleta.Click += new System.EventHandler(this.buttonDeleta_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(188, 213);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(79, 67);
            this.button6.TabIndex = 7;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(98, 213);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 67);
            this.button7.TabIndex = 8;
            this.button7.Text = "8";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(273, 140);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(77, 67);
            this.button8.TabIndex = 9;
            this.button8.Text = "÷";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(100, 286);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(82, 67);
            this.button9.TabIndex = 10;
            this.button9.Text = "5";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(273, 213);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(77, 67);
            this.button10.TabIndex = 11;
            this.button10.Text = "X";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(0, 286);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(94, 67);
            this.button11.TabIndex = 12;
            this.button11.Text = "4";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(188, 286);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(79, 67);
            this.button12.TabIndex = 13;
            this.button12.Text = "6";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 359);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 67);
            this.button13.TabIndex = 14;
            this.button13.Text = "1";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(100, 359);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 67);
            this.button14.TabIndex = 15;
            this.button14.Text = "2";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(188, 359);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(77, 67);
            this.button15.TabIndex = 16;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // buttonApaga
            // 
            this.buttonApaga.Location = new System.Drawing.Point(0, 432);
            this.buttonApaga.Name = "buttonApaga";
            this.buttonApaga.Size = new System.Drawing.Size(94, 67);
            this.buttonApaga.TabIndex = 17;
            this.buttonApaga.Text = "Del";
            this.buttonApaga.UseVisualStyleBackColor = true;
            this.buttonApaga.Click += new System.EventHandler(this.buttonApaga_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(100, 432);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(86, 67);
            this.button17.TabIndex = 18;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(190, 432);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(77, 67);
            this.button18.TabIndex = 19;
            this.button18.Text = ",";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // buttonParenteses
            // 
            this.buttonParenteses.Location = new System.Drawing.Point(277, 432);
            this.buttonParenteses.Name = "buttonParenteses";
            this.buttonParenteses.Size = new System.Drawing.Size(73, 67);
            this.buttonParenteses.TabIndex = 20;
            this.buttonParenteses.Text = "()";
            this.buttonParenteses.UseVisualStyleBackColor = true;
            this.buttonParenteses.Click += new System.EventHandler(this.buttonParenteses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 529);
            this.Controls.Add(this.buttonParenteses);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.buttonApaga);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonDeleta);
            this.Controls.Add(this.buttonMenos);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form1";
            this.Text = "Jonas Gordo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDisplay;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonMenos;
        private System.Windows.Forms.Button buttonDeleta;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button buttonApaga;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button buttonParenteses;
    }
}

