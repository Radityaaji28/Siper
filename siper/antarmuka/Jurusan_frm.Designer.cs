
namespace siper.antarmuka
{
    partial class Jurusan_frm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.id_txt = new System.Windows.Forms.TextBox();
            this.check_btn = new System.Windows.Forms.Button();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.simpan_btn = new System.Windows.Forms.Button();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.batal_txt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tutup_btn = new System.Windows.Forms.Button();
            this.jurusan_dgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.cari_txt = new System.Windows.Forms.TextBox();
            this.cari_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jurusan_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // id_txt
            // 
            this.id_txt.Location = new System.Drawing.Point(160, 35);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(152, 20);
            this.id_txt.TabIndex = 0;
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(318, 32);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 1;
            this.check_btn.Text = "Check";
            this.check_btn.UseVisualStyleBackColor = true;
            this.check_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // nama_txt
            // 
            this.nama_txt.Location = new System.Drawing.Point(160, 61);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(233, 20);
            this.nama_txt.TabIndex = 2;
            // 
            // simpan_btn
            // 
            this.simpan_btn.Location = new System.Drawing.Point(160, 87);
            this.simpan_btn.Name = "simpan_btn";
            this.simpan_btn.Size = new System.Drawing.Size(75, 23);
            this.simpan_btn.TabIndex = 3;
            this.simpan_btn.Text = "Simpan";
            this.simpan_btn.UseVisualStyleBackColor = true;
            this.simpan_btn.Click += new System.EventHandler(this.simpan_btn_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.Location = new System.Drawing.Point(241, 87);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(71, 23);
            this.hapus_btn.TabIndex = 4;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = true;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // batal_txt
            // 
            this.batal_txt.Location = new System.Drawing.Point(318, 87);
            this.batal_txt.Name = "batal_txt";
            this.batal_txt.Size = new System.Drawing.Size(75, 23);
            this.batal_txt.TabIndex = 5;
            this.batal_txt.Text = "Batal";
            this.batal_txt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID JURUSAN :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "NAMA JURUSAN :";
            // 
            // tutup_btn
            // 
            this.tutup_btn.Location = new System.Drawing.Point(160, 116);
            this.tutup_btn.Name = "tutup_btn";
            this.tutup_btn.Size = new System.Drawing.Size(233, 23);
            this.tutup_btn.TabIndex = 8;
            this.tutup_btn.Text = "Tutup";
            this.tutup_btn.UseVisualStyleBackColor = true;
            this.tutup_btn.Click += new System.EventHandler(this.tutup_btn_Click);
            // 
            // jurusan_dgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.jurusan_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.jurusan_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jurusan_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama});
            this.jurusan_dgv.Location = new System.Drawing.Point(12, 194);
            this.jurusan_dgv.Name = "jurusan_dgv";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jurusan_dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.jurusan_dgv.Size = new System.Drawing.Size(424, 150);
            this.jurusan_dgv.TabIndex = 9;
            this.jurusan_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jurusan_dgv_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id_jurusan";
            this.id.HeaderText = "ID JURUSAN";
            this.id.Name = "id";
            this.id.Width = 190;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama_jurusan";
            this.nama.HeaderText = "NAMA JURUSAN";
            this.nama.Name = "nama";
            this.nama.Width = 190;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 9);
            this.label3.TabIndex = 10;
            this.label3.Text = "CARI NAMA JURUSAN :";
            // 
            // cari_txt
            // 
            this.cari_txt.Location = new System.Drawing.Point(39, 167);
            this.cari_txt.Name = "cari_txt";
            this.cari_txt.Size = new System.Drawing.Size(273, 20);
            this.cari_txt.TabIndex = 11;
            this.cari_txt.TextChanged += new System.EventHandler(this.cari_txt_TextChanged);
            // 
            // cari_btn
            // 
            this.cari_btn.Location = new System.Drawing.Point(318, 165);
            this.cari_btn.Name = "cari_btn";
            this.cari_btn.Size = new System.Drawing.Size(75, 23);
            this.cari_btn.TabIndex = 12;
            this.cari_btn.Text = "Cari";
            this.cari_btn.UseVisualStyleBackColor = true;
            this.cari_btn.Click += new System.EventHandler(this.cari_btn_Click);
            // 
            // Jurusan_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 356);
            this.Controls.Add(this.cari_btn);
            this.Controls.Add(this.cari_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jurusan_dgv);
            this.Controls.Add(this.tutup_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.batal_txt);
            this.Controls.Add(this.hapus_btn);
            this.Controls.Add(this.simpan_btn);
            this.Controls.Add(this.nama_txt);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.id_txt);
            this.Name = "Jurusan_frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jurusan_frm";
            this.Load += new System.EventHandler(this.Jurusan_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jurusan_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.Button simpan_btn;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button batal_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tutup_btn;
        private System.Windows.Forms.DataGridView jurusan_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cari_txt;
        private System.Windows.Forms.Button cari_btn;
    }
}