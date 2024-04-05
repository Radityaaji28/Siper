
namespace siper.antarmuka
{
    partial class dashboard_frm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jurusanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programStudiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.anggotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataMasterToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataMasterToolStripMenuItem
            // 
            this.dataMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jurusanToolStripMenuItem,
            this.programStudiToolStripMenuItem,
            this.toolStripSeparator1,
            this.anggotaToolStripMenuItem});
            this.dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            this.dataMasterToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.dataMasterToolStripMenuItem.Text = "Data Master";
            // 
            // jurusanToolStripMenuItem
            // 
            this.jurusanToolStripMenuItem.Name = "jurusanToolStripMenuItem";
            this.jurusanToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jurusanToolStripMenuItem.Text = "Jurusan";
            this.jurusanToolStripMenuItem.Click += new System.EventHandler(this.jurusanToolStripMenuItem_Click);
            // 
            // programStudiToolStripMenuItem
            // 
            this.programStudiToolStripMenuItem.Name = "programStudiToolStripMenuItem";
            this.programStudiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.programStudiToolStripMenuItem.Text = "Program Studi";
            this.programStudiToolStripMenuItem.Click += new System.EventHandler(this.programStudiToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // anggotaToolStripMenuItem
            // 
            this.anggotaToolStripMenuItem.Name = "anggotaToolStripMenuItem";
            this.anggotaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.anggotaToolStripMenuItem.Text = "Anggota";
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // dashboard_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 369);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "dashboard_frm";
            this.Text = "dashboard_frm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jurusanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programStudiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem anggotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}