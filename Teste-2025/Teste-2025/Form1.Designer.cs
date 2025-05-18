namespace Teste_2025
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
            txtNumero = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(49, 197);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(135, 23);
            txtNumero.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(360, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(218, 259);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(47, 39);
            button1.Name = "button1";
            button1.Size = new Size(243, 23);
            button1.TabIndex = 2;
            button1.Text = "Somar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(49, 226);
            button2.Name = "button2";
            button2.Size = new Size(243, 23);
            button2.TabIndex = 2;
            button2.Text = "Verificar se o número é Fibonacci";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(47, 68);
            button3.Name = "button3";
            button3.Size = new Size(243, 23);
            button3.TabIndex = 2;
            button3.Text = "Exercício XML JSON";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(47, 97);
            button4.Name = "button4";
            button4.Size = new Size(243, 23);
            button4.TabIndex = 2;
            button4.Text = "Calcular Percentual";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(47, 126);
            button5.Name = "button5";
            button5.Size = new Size(243, 23);
            button5.TabIndex = 2;
            button5.Text = "Inverter Caracteres";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 179);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 7;
            label1.Text = "Digite um número inteiro:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(604, 344);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(txtNumero);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
    }
}
