namespace zh3_akos
{
    partial class ExcelUc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            excelButton = new Button();
            diagramButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // excelButton
            // 
            excelButton.Location = new Point(215, 132);
            excelButton.Name = "excelButton";
            excelButton.Size = new Size(86, 59);
            excelButton.TabIndex = 0;
            excelButton.Text = "Excel";
            excelButton.UseVisualStyleBackColor = true;
            excelButton.Click += excelButton_Click;
            // 
            // diagramButton
            // 
            diagramButton.Location = new Point(392, 132);
            diagramButton.Name = "diagramButton";
            diagramButton.Size = new Size(98, 59);
            diagramButton.TabIndex = 1;
            diagramButton.Text = "Diagram";
            diagramButton.UseVisualStyleBackColor = true;
            diagramButton.Click += diagramButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 103);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 2;
            textBox1.Text = "Excel generálása kódból!";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(392, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(157, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Diagram generálása kódból!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(297, 34);
            label1.Name = "label1";
            label1.Size = new Size(166, 25);
            label1.TabIndex = 4;
            label1.Text = "Excel User Control";
            // 
            // ExcelUc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.ForestGreen;
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(diagramButton);
            Controls.Add(excelButton);
            Name = "ExcelUc";
            Size = new Size(781, 470);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button excelButton;
        private Button diagramButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
    }
}
