namespace zh3_akos
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
            RendelesekBtn = new Button();
            ExcelBtn = new Button();
            VasarlasokBtn = new Button();
            OkossagokBtn = new Button();
            DataGridViewBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // RendelesekBtn
            // 
            RendelesekBtn.Location = new Point(123, 39);
            RendelesekBtn.Name = "RendelesekBtn";
            RendelesekBtn.Size = new Size(86, 23);
            RendelesekBtn.TabIndex = 0;
            RendelesekBtn.Text = "Rendelések";
            RendelesekBtn.UseVisualStyleBackColor = true;
            RendelesekBtn.Click += RendelesekBtn_Click;
            // 
            // ExcelBtn
            // 
            ExcelBtn.Location = new Point(123, 68);
            ExcelBtn.Name = "ExcelBtn";
            ExcelBtn.Size = new Size(86, 23);
            ExcelBtn.TabIndex = 1;
            ExcelBtn.Text = "Excel";
            ExcelBtn.UseVisualStyleBackColor = true;
            ExcelBtn.Click += TermekekBtn_Click;
            // 
            // VasarlasokBtn
            // 
            VasarlasokBtn.Location = new Point(123, 97);
            VasarlasokBtn.Name = "VasarlasokBtn";
            VasarlasokBtn.Size = new Size(86, 23);
            VasarlasokBtn.TabIndex = 2;
            VasarlasokBtn.Text = "Vásárlások";
            VasarlasokBtn.UseVisualStyleBackColor = true;
            VasarlasokBtn.Click += VasarlasokBtn_Click;
            // 
            // OkossagokBtn
            // 
            OkossagokBtn.Location = new Point(123, 154);
            OkossagokBtn.Name = "OkossagokBtn";
            OkossagokBtn.Size = new Size(86, 23);
            OkossagokBtn.TabIndex = 3;
            OkossagokBtn.Text = "Okosságok";
            OkossagokBtn.UseVisualStyleBackColor = true;
            OkossagokBtn.Click += OkossagokBtn_Click;
            // 
            // DataGridViewBtn
            // 
            DataGridViewBtn.Location = new Point(123, 183);
            DataGridViewBtn.Name = "DataGridViewBtn";
            DataGridViewBtn.Size = new Size(86, 23);
            DataGridViewBtn.TabIndex = 4;
            DataGridViewBtn.Text = "DataGridView";
            DataGridViewBtn.UseVisualStyleBackColor = true;
            DataGridViewBtn.Click += DataGridViewBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 72);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 5;
            label1.Text = "User Controlok";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 172);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 6;
            label2.Text = "Formok";
            // 
            // panel1
            // 
            panel1.Controls.Add(DataGridViewBtn);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(OkossagokBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(RendelesekBtn);
            panel1.Controls.Add(ExcelBtn);
            panel1.Controls.Add(VasarlasokBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 581);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 581);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button RendelesekBtn;
        private Button ExcelBtn;
        private Button VasarlasokBtn;
        private Button OkossagokBtn;
        private Button DataGridViewBtn;
        private Label label1;
        private Label label2;
        private Panel panel1;
    }
}