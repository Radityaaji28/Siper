
namespace siper.antarmuka
{
    partial class prodi_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cari_btn = new System.Windows.Forms.Button();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.prodi_dgv = new System.Windows.Forms.DataGridView();
            this.tutup_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.batal_txt = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.Button();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusan_cmb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.prodi_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // cari_btn
            // 
            this.cari_btn.Location = new System.Drawing.Point(338, 175);
            this.cari_btn.Name = "cari_btn";
            this.cari_btn.Size = new System.Drawing.Size(75, 23);
            this.cari_btn.TabIndex = 25;
            this.cari_btn.Text = "Cari";
            this.cari_btn.UseVisualStyleBackColor = true;
            this.cari_btn.Click += new System.EventHandler(this.cari_btn_Click);
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(59, 177);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(273, 20);
            this.cari_txt.TabIndex = 24;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 9);
            this.label3.TabIndex = 23;
            this.label3.Text = "CARI NAMA PRODI :";
            // 
            // prodi_dgv
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.prodi_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.prodi_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodi_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama,
            this.jurusan});
            this.prodi_dgv.Location = new System.Drawing.Point(32, 204);
            this.prodi_dgv.Name = "prodi_dgv";
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodi_dgv.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.prodi_dgv.Size = new System.Drawing.Size(424, 150);
            this.prodi_dgv.TabIndex = 22;
            this.prodi_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.prodi_dgv_CellClick);
            // 
            // tutup_btn
            // 
            this.tutup_btn.Location = new System.Drawing.Point(180, 148);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(233, 23);
            this.tutup_btn.TabIndex = 21;
            this.tutup_btn.Text = "Tutup";
            this.tutup_btn.UseVisualStyleBackColor = true;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "NAMA PRODI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID PRODI :";
            // 
            // batal_txt
            // 
            this.batal_txt.Location = new System.Drawing.Point(338, 119);
            this.batal_txt.Name = "batal_txt";
            this.batal_txt.Size = new System.Drawing.Size(75, 23);
            this.batal_txt.TabIndex = 18;
            this.batal_txt.Text = "Batal";
            this.batal_txt.UseVisualStyleBackColor = true;
            // 
            // hapus_btn
            // 
            this.hapus_btn.Location = new System.Drawing.Point(261, 119);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(71, 23);
            this.hapus_btn.TabIndex = 17;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // simpan_btn
            // 
            this.simpan_btn.Location = new System.Drawing.Point(180, 119);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(75, 23);
            this.simpan_btn.TabIndex = 16;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // nama_txt
            // 
            this.nama_txt.Location = new System.Drawing.Point(180, 60);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(233, 20);
            this.nama_txt.TabIndex = 15;
            this.nama_txt.TextChanged += new System.EventHandler(this.nama_txt_TextChanged);
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(338, 34);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 14;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.check_btn_Click);
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(180, 34);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(152, 20);
            this.id_txt.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "JURUSAN :";
            // 
            // id
            // 
            this.id.DataPropertyName = "id_prodi";
            this.id.HeaderText = "ID PRODI";
            this.id.Name = "id";
            this.id.Width = 120;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama_prodi";
            this.nama.HeaderText = "NAMA PRODI";
            this.nama.Name = "nama";
            this.nama.Width = 130;
            // 
            // jurusan
            // 
            this.jurusan.DataPropertyName = "jurusan";
            this.jurusan.HeaderText = "JURUSAN";
            this.jurusan.Name = "jurusan";
            this.jurusan.Width = 130;
            // 
            // jurusan_cmb
            // 
            this.jurusan_cmb.FormattingEnabled = true;
            this.jurusan_cmb.Location = new System.Drawing.Point(180, 86);
            this.jurusan_cmb.Name = "jurusan_cmb";
            this.jurusan_cmb.Size = new System.Drawing.Size(233, 21);
            this.jurusan_cmb.TabIndex = 28;
            // 
            // prodi_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 376);
            this.Controls.Add(this.jurusan_cmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cari_btn);
            this.Controls.Add(this.cari_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodi_dgv);
            this.Controls.Add(this.tutup_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.batal_txt);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.nama_txt);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.id_txt);
            this.Name = "prodi_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "prodi_frm";
            this.Load += new System.EventHandler(this.prodi_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prodi_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cari_btn;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView prodi_dgv;
        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button batal_txt;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurusan;
        private System.Windows.Forms.ComboBox jurusan_cmb;
    }
}