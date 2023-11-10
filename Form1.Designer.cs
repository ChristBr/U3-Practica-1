namespace U3_Practica_1
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
            listBox1 = new ListBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.PapayaWhip;
            listBox1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 22;
            listBox1.Location = new Point(32, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 246);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightYellow;
            button1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(209, 157);
            button1.Name = "button1";
            button1.Size = new Size(138, 53);
            button1.TabIndex = 1;
            button1.Text = "Listar números";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(60, 21);
            label1.Name = "label1";
            label1.Size = new Size(268, 24);
            label1.TabIndex = 2;
            label1.Text = "Escribe los números del 1 al 11";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(372, 341);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Imprimir números";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Label label1;
    }
}