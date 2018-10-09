namespace Latihanwinform
{
    partial class FrmListMahasiswa
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.rdoPerempuan = new System.Windows.Forms.RadioButton();
            this.rdoLakilaki = new System.Windows.Forms.RadioButton();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.mskNpm = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvwMahasiswa = new System.Windows.Forms.ListView();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jenis Kelamin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tempat Lahir";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tanggal Lahir";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpTanggalLahir);
            this.groupBox1.Controls.Add(this.txtTempatLahir);
            this.groupBox1.Controls.Add(this.rdoPerempuan);
            this.groupBox1.Controls.Add(this.rdoLakilaki);
            this.groupBox1.Controls.Add(this.txtNama);
            this.groupBox1.Controls.Add(this.mskNpm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 271);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Mahasiswa";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggalLahir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(112, 170);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(170, 21);
            this.dtpTanggalLahir.TabIndex = 5;
            this.dtpTanggalLahir.Value = new System.DateTime(2018, 10, 8, 0, 0, 0, 0);
            this.dtpTanggalLahir.ValueChanged += new System.EventHandler(this.dtpTanggalLahir_ValueChanged);
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempatLahir.Location = new System.Drawing.Point(112, 132);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(170, 22);
            this.txtTempatLahir.TabIndex = 4;
            this.txtTempatLahir.TextChanged += new System.EventHandler(this.txtTempatLahir_TextChanged);
            // 
            // rdoPerempuan
            // 
            this.rdoPerempuan.AutoSize = true;
            this.rdoPerempuan.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPerempuan.Location = new System.Drawing.Point(195, 94);
            this.rdoPerempuan.Name = "rdoPerempuan";
            this.rdoPerempuan.Size = new System.Drawing.Size(100, 20);
            this.rdoPerempuan.TabIndex = 3;
            this.rdoPerempuan.Text = "Perempuan";
            this.rdoPerempuan.UseVisualStyleBackColor = true;
            this.rdoPerempuan.CheckedChanged += new System.EventHandler(this.rdoPerempuan_CheckedChanged);
            // 
            // rdoLakilaki
            // 
            this.rdoLakilaki.AutoSize = true;
            this.rdoLakilaki.Checked = true;
            this.rdoLakilaki.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLakilaki.Location = new System.Drawing.Point(112, 94);
            this.rdoLakilaki.Name = "rdoLakilaki";
            this.rdoLakilaki.Size = new System.Drawing.Size(80, 20);
            this.rdoLakilaki.TabIndex = 3;
            this.rdoLakilaki.TabStop = true;
            this.rdoLakilaki.Text = "Laki-laki";
            this.rdoLakilaki.UseVisualStyleBackColor = true;
            this.rdoLakilaki.CheckedChanged += new System.EventHandler(this.rdoLakilaki_CheckedChanged);
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(112, 57);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(170, 22);
            this.txtNama.TabIndex = 2;
            this.txtNama.TextChanged += new System.EventHandler(this.txtNama_TextChanged);
            // 
            // mskNpm
            // 
            this.mskNpm.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNpm.Location = new System.Drawing.Point(112, 25);
            this.mskNpm.Mask = "##.##.####";
            this.mskNpm.Name = "mskNpm";
            this.mskNpm.Size = new System.Drawing.Size(102, 22);
            this.mskNpm.TabIndex = 1;
            this.mskNpm.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskNpm_MaskInputRejected);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvwMahasiswa);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(322, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(652, 271);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Mahasiswa";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lvwMahasiswa
            // 
            this.lvwMahasiswa.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMahasiswa.Location = new System.Drawing.Point(10, 18);
            this.lvwMahasiswa.Name = "lvwMahasiswa";
            this.lvwMahasiswa.Size = new System.Drawing.Size(636, 247);
            this.lvwMahasiswa.TabIndex = 0;
            this.lvwMahasiswa.UseCompatibleStateImageBehavior = false;
            this.lvwMahasiswa.SelectedIndexChanged += new System.EventHandler(this.lvwMahasiswa_SelectedIndexChanged);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Location = new System.Drawing.Point(12, 298);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(67, 25);
            this.btnSimpan.TabIndex = 3;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(104, 298);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(67, 25);
            this.btnHapus.TabIndex = 3;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(901, 298);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(67, 25);
            this.btnTutup.TabIndex = 3;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // FrmListMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 335);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmListMahasiswa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mahasiswa";
            this.Load += new System.EventHandler(this.FrmListMahasiswa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.RadioButton rdoPerempuan;
        private System.Windows.Forms.RadioButton rdoLakilaki;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.MaskedTextBox mskNpm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvwMahasiswa;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnTutup;
    }
}