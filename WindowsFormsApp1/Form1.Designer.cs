namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tittle = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblupdate = new System.Windows.Forms.Label();
            this.Txt_desc = new System.Windows.Forms.RichTextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tittle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // txt_tittle
            // 
            this.txt_tittle.Location = new System.Drawing.Point(163, 22);
            this.txt_tittle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_tittle.Name = "txt_tittle";
            this.txt_tittle.Size = new System.Drawing.Size(349, 26);
            this.txt_tittle.TabIndex = 3;
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(555, 22);
            this.btn_tambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(130, 39);
            this.btn_tambah.TabIndex = 6;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(555, 65);
            this.btn_simpan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(130, 34);
            this.btn_simpan.TabIndex = 7;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(555, 103);
            this.btn_hapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(130, 46);
            this.btn_hapus.TabIndex = 8;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 214);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(650, 210);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // lblupdate
            // 
            this.lblupdate.AutoSize = true;
            this.lblupdate.BackColor = System.Drawing.SystemColors.Menu;
            this.lblupdate.ForeColor = System.Drawing.SystemColors.Menu;
            this.lblupdate.Location = new System.Drawing.Point(356, 25);
            this.lblupdate.Name = "lblupdate";
            this.lblupdate.Size = new System.Drawing.Size(51, 20);
            this.lblupdate.TabIndex = 10;
            this.lblupdate.Text = "label4";
            // 
            // Txt_desc
            // 
            this.Txt_desc.Location = new System.Drawing.Point(163, 53);
            this.Txt_desc.Name = "Txt_desc";
            this.Txt_desc.Size = new System.Drawing.Size(349, 96);
            this.Txt_desc.TabIndex = 11;
            this.Txt_desc.Text = "";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.SystemColors.Menu;
            this.labelID.ForeColor = System.Drawing.SystemColors.Menu;
            this.labelID.Location = new System.Drawing.Point(356, 63);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(51, 20);
            this.labelID.TabIndex = 12;
            this.labelID.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Status";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(163, 156);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(349, 28);
            this.cmbStatus.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 485);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.Txt_desc);
            this.Controls.Add(this.lblupdate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.txt_tittle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Tasklist";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tittle;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblupdate;
        private System.Windows.Forms.RichTextBox Txt_desc;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatus;
    }
}

