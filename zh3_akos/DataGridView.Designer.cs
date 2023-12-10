namespace zh3_akos
{
    partial class DataGridView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxSzallitok = new ListBox();
            listBoxRendelesek = new ListBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            textBoxSzallitok = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // listBoxSzallitok
            // 
            listBoxSzallitok.FormattingEnabled = true;
            listBoxSzallitok.ItemHeight = 32;
            listBoxSzallitok.Location = new Point(56, 124);
            listBoxSzallitok.Margin = new Padding(6);
            listBoxSzallitok.Name = "listBoxSzallitok";
            listBoxSzallitok.Size = new Size(229, 772);
            listBoxSzallitok.TabIndex = 0;
            listBoxSzallitok.SelectedIndexChanged += listBoxSzallitok_SelectedIndexChanged;
            // 
            // listBoxRendelesek
            // 
            listBoxRendelesek.FormattingEnabled = true;
            listBoxRendelesek.ItemHeight = 32;
            listBoxRendelesek.Location = new Point(331, 124);
            listBoxRendelesek.Margin = new Padding(6);
            listBoxRendelesek.Name = "listBoxRendelesek";
            listBoxRendelesek.Size = new Size(229, 772);
            listBoxRendelesek.TabIndex = 1;
            listBoxRendelesek.SelectedIndexChanged += listBoxRendelesek_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(754, 119);
            dataGridView1.Margin = new Padding(6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1057, 777);
            dataGridView1.TabIndex = 4;
            // 
            // textBoxSzallitok
            // 
            textBoxSzallitok.Location = new Point(56, 61);
            textBoxSzallitok.Margin = new Padding(6);
            textBoxSzallitok.Name = "textBoxSzallitok";
            textBoxSzallitok.Size = new Size(182, 39);
            textBoxSzallitok.TabIndex = 5;
            textBoxSzallitok.TextChanged += textBoxSzallitok_TextChanged;
            // 
            // DataGridView
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1887, 1057);
            Controls.Add(textBoxSzallitok);
            Controls.Add(dataGridView1);
            Controls.Add(listBoxRendelesek);
            Controls.Add(listBoxSzallitok);
            Margin = new Padding(6);
            Name = "DataGridView";
            Text = "DataGridView";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxSzallitok;
        private ListBox listBoxRendelesek;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TextBox textBoxSzallitok;
    }
}