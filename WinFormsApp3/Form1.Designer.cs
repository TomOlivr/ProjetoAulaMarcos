namespace WinFormsApp3
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
            lbValor1 = new Label();
            lbValor2 = new Label();
            tbValor1 = new TextBox();
            tbValor2 = new TextBox();
            label1 = new Label();
            btnSoma = new Button();
            SuspendLayout();
            // 
            // lbValor1
            // 
            lbValor1.AutoSize = true;
            lbValor1.Location = new Point(53, 49);
            lbValor1.Name = "lbValor1";
            lbValor1.Size = new Size(42, 15);
            lbValor1.TabIndex = 0;
            lbValor1.Text = "Valor 1";
            // 
            // lbValor2
            // 
            lbValor2.AutoSize = true;
            lbValor2.Location = new Point(53, 118);
            lbValor2.Name = "lbValor2";
            lbValor2.Size = new Size(42, 15);
            lbValor2.TabIndex = 1;
            lbValor2.Text = "Valor 2";
            // 
            // tbValor1
            // 
            tbValor1.Location = new Point(114, 41);
            tbValor1.Name = "tbValor1";
            tbValor1.Size = new Size(100, 23);
            tbValor1.TabIndex = 2;
            // 
            // tbValor2
            // 
            tbValor2.Location = new Point(114, 110);
            tbValor2.Name = "tbValor2";
            tbValor2.Size = new Size(100, 23);
            tbValor2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 167);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 4;
            label1.Text = "Total";
            // 
            // btnSoma
            // 
            btnSoma.Location = new Point(53, 206);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 23);
            btnSoma.TabIndex = 5;
            btnSoma.Text = "Soma";
            btnSoma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSoma);
            Controls.Add(label1);
            Controls.Add(tbValor2);
            Controls.Add(tbValor1);
            Controls.Add(lbValor2);
            Controls.Add(lbValor1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbValor1;
        private Label lbValor2;
        private TextBox tbValor1;
        private TextBox tbValor2;
        private Label label1;
        private Button btnSoma;
    }
}
