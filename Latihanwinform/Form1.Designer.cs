namespace Latihanwinform
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
            this.label3 = new System.Windows.Forms.Label();
            this.mskNPM = new System.Windows.Forms.MaskedTextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.rdoLakilaki = new System.Windows.Forms.RadioButton();
            this.rdoPerempuan = new System.Windows.Forms.RadioButton();
            this.btnTampil = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTempatLahir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpTanggalLahir = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NPM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Jenis Kelamin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mskNPM
            // 
            this.mskNPM.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskNPM.Location = new System.Drawing.Point(98, 12);
            this.mskNPM.Mask = "##.##.####";
            this.mskNPM.Name = "mskNPM";
            this.mskNPM.Size = new System.Drawing.Size(107, 21);
            this.mskNPM.TabIndex = 1;
            this.mskNPM.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskNPM_MaskInputRejected);
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(98, 44);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(180, 21);
            this.txtNama.TabIndex = 2;
            // 
            // rdoLakilaki
            // 
            this.rdoLakilaki.AutoSize = true;
            this.rdoLakilaki.Checked = true;
            this.rdoLakilaki.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoLakilaki.Location = new System.Drawing.Point(98, 79);
            this.rdoLakilaki.Name = "rdoLakilaki";
            this.rdoLakilaki.Size = new System.Drawing.Size(67, 19);
            this.rdoLakilaki.TabIndex = 3;
            this.rdoLakilaki.TabStop = true;
            this.rdoLakilaki.Text = "Laki-laki";
            this.rdoLakilaki.UseVisualStyleBackColor = true;
            // 
            // rdoPerempuan
            // 
            this.rdoPerempuan.AutoSize = true;
            this.rdoPerempuan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoPerempuan.Location = new System.Drawing.Point(199, 79);
            this.rdoPerempuan.Name = "rdoPerempuan";
            this.rdoPerempuan.Size = new System.Drawing.Size(79, 19);
            this.rdoPerempuan.TabIndex = 3;
            this.rdoPerempuan.Text = "Perempuan";
            this.rdoPerempuan.UseVisualStyleBackColor = true;
            // 
            // btnTampil
            // 
            this.btnTampil.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTampil.Location = new System.Drawing.Point(12, 189);
            this.btnTampil.Name = "btnTampil";
            this.btnTampil.Size = new System.Drawing.Size(63, 24);
            this.btnTampil.TabIndex = 4;
            this.btnTampil.Text = "Tampil";
            this.btnTampil.UseVisualStyleBackColor = true;
            this.btnTampil.Click += new System.EventHandler(this.btnTampil_Click);
            // 
            // btnTutup
            // 
            this.btnTutup.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTutup.Location = new System.Drawing.Point(215, 189);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(63, 24);
            this.btnTutup.TabIndex = 4;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = true;
            this.btnTutup.Click += new System.EventHandler(this.btnTutup_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tempat Lahir";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtTempatLahir
            // 
            this.txtTempatLahir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTempatLahir.Location = new System.Drawing.Point(98, 112);
            this.txtTempatLahir.Name = "txtTempatLahir";
            this.txtTempatLahir.Size = new System.Drawing.Size(180, 21);
            this.txtTempatLahir.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tanggal Lahir";
            this.label5.Click += new System.EventHandler(this.label4_Click);
            // 
            // dtpTanggalLahir
            // 
            this.dtpTanggalLahir.CustomFormat = "dd/MM/yyyy";
            this.dtpTanggalLahir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTanggalLahir.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTanggalLahir.Location = new System.Drawing.Point(98, 142);
            this.dtpTanggalLahir.Name = "dtpTanggalLahir";
            this.dtpTanggalLahir.Size = new System.Drawing.Size(180, 21);
            this.dtpTanggalLahir.TabIndex = 7;
            this.dtpTanggalLahir.Value = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 237);
            this.Controls.Add(this.dtpTanggalLahir);
            this.Controls.Add(this.txtTempatLahir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTutup);
            this.Controls.Add(this.btnTampil);
            this.Controls.Add(this.rdoPerempuan);
            this.Controls.Add(this.rdoLakilaki);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.mskNPM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Mahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskNPM;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.RadioButton rdoLakilaki;
        private System.Windows.Forms.RadioButton rdoPerempuan;
        private System.Windows.Forms.Button btnTampil;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTempatLahir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpTanggalLahir;
    }
}

