namespace zh3_akos
{
    partial class SzallitokUc
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textBoxNev = new TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            textBoxTelszam = new TextBox();
            btnPlusz = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(526, 76);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(275, 32);
            label1.TabIndex = 2;
            label1.Text = "Rendelések User Control";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(175, 126);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 32);
            label2.TabIndex = 3;
            label2.Text = "Szűrés";
            // 
            // textBoxNev
            // 
            textBoxNev.Location = new Point(175, 200);
            textBoxNev.Margin = new Padding(6);
            textBoxNev.Name = "textBoxNev";
            textBoxNev.Size = new Size(182, 39);
            textBoxNev.TabIndex = 4;
            textBoxNev.TextChanged += textBoxNev_TextChanged;
            textBoxNev.Validating += textBoxNev_Validating;
            textBoxNev.Validated += textBoxNev_Validated;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(487, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1076, 778);
            dataGridView1.TabIndex = 5;
            // 
            // textBoxTelszam
            // 
            textBoxTelszam.Location = new Point(175, 275);
            textBoxTelszam.Margin = new Padding(6);
            textBoxTelszam.Name = "textBoxTelszam";
            textBoxTelszam.Size = new Size(182, 39);
            textBoxTelszam.TabIndex = 6;
            textBoxTelszam.Validating += textBoxTelszam_Validating;
            textBoxTelszam.Validated += textBoxTelszam_Validated;
            // 
            // btnPlusz
            // 
            btnPlusz.Location = new Point(175, 357);
            btnPlusz.Name = "btnPlusz";
            btnPlusz.Size = new Size(182, 46);
            btnPlusz.TabIndex = 7;
            btnPlusz.Text = "+";
            btnPlusz.UseVisualStyleBackColor = true;
            btnPlusz.Click += btnPlusz_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // SzallitokUc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            Controls.Add(btnPlusz);
            Controls.Add(textBoxTelszam);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxNev);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "SzallitokUc";
            Size = new Size(1652, 1169);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSzures;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Button btnPlusz;
        private ErrorProvider errorProvider1;
        public TextBox textBoxNev;
        public TextBox textBoxTelszam;
    }
}
