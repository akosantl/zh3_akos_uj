namespace zh3_akos
{
    partial class VasarlasokUc
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
            textBoxNev = new TextBox();
            textBoxOrszag = new TextBox();
            textBoxTevekenyseg = new TextBox();
            buttonPlusz = new Button();
            label1 = new Label();
            listBoxSzallitok = new ListBox();
            buttonMinusz = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxNev
            // 
            textBoxNev.Location = new Point(153, 208);
            textBoxNev.Name = "textBoxNev";
            textBoxNev.Size = new Size(200, 39);
            textBoxNev.TabIndex = 0;
            textBoxNev.TextChanged += textBoxNev_TextChanged;
            // 
            // textBoxOrszag
            // 
            textBoxOrszag.Location = new Point(153, 318);
            textBoxOrszag.Name = "textBoxOrszag";
            textBoxOrszag.Size = new Size(200, 39);
            textBoxOrszag.TabIndex = 1;
            textBoxOrszag.TextChanged += textBoxOrszag_TextChanged;
            // 
            // textBoxTevekenyseg
            // 
            textBoxTevekenyseg.Location = new Point(153, 445);
            textBoxTevekenyseg.Name = "textBoxTevekenyseg";
            textBoxTevekenyseg.Size = new Size(200, 39);
            textBoxTevekenyseg.TabIndex = 2;
            textBoxTevekenyseg.TextChanged += textBoxTevekenyseg_TextChanged;
            // 
            // buttonPlusz
            // 
            buttonPlusz.Location = new Point(626, 774);
            buttonPlusz.Name = "buttonPlusz";
            buttonPlusz.Size = new Size(168, 59);
            buttonPlusz.TabIndex = 3;
            buttonPlusz.Text = "+";
            buttonPlusz.UseVisualStyleBackColor = true;
            buttonPlusz.Click += buttonOk_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 160);
            label1.Name = "label1";
            label1.Size = new Size(144, 32);
            label1.TabIndex = 5;
            label1.Text = "Szállító Név:";
            // 
            // listBoxSzallitok
            // 
            listBoxSzallitok.FormattingEnabled = true;
            listBoxSzallitok.ItemHeight = 32;
            listBoxSzallitok.Location = new Point(626, 186);
            listBoxSzallitok.Name = "listBoxSzallitok";
            listBoxSzallitok.Size = new Size(449, 548);
            listBoxSzallitok.TabIndex = 6;
            // 
            // buttonMinusz
            // 
            buttonMinusz.Location = new Point(800, 774);
            buttonMinusz.Name = "buttonMinusz";
            buttonMinusz.Size = new Size(168, 59);
            buttonMinusz.TabIndex = 7;
            buttonMinusz.Text = "-";
            buttonMinusz.UseVisualStyleBackColor = true;
            buttonMinusz.Click += buttonMinusz_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 266);
            label2.Name = "label2";
            label2.Size = new Size(92, 32);
            label2.TabIndex = 8;
            label2.Text = "Ország:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 397);
            label3.Name = "label3";
            label3.Size = new Size(242, 32);
            label3.TabIndex = 9;
            label3.Text = "Tevékenységi Terület:";
            // 
            // VasarlasokUc
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonMinusz);
            Controls.Add(listBoxSzallitok);
            Controls.Add(label1);
            Controls.Add(buttonPlusz);
            Controls.Add(textBoxTevekenyseg);
            Controls.Add(textBoxOrszag);
            Controls.Add(textBoxNev);
            Margin = new Padding(6);
            Name = "VasarlasokUc";
            Size = new Size(1317, 919);
            Load += VasarlasokUc_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonPlusz;
        private Label label1;
        public TextBox textBoxNev;
        public TextBox textBoxOrszag;
        public TextBox textBoxTevekenyseg;
        private ListBox listBoxSzallitok;
        private Button buttonMinusz;
        private Label label2;
        private Label label3;
    }
}
