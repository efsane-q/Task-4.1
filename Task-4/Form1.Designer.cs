namespace Task_4
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
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblYas = new System.Windows.Forms.Label();
            this.nudYas = new System.Windows.Forms.NumericUpDown();
            this.lblKurs = new System.Windows.Forms.Label();
            this.cmbKurs = new System.Windows.Forms.ComboBox();
            this.lblCins = new System.Windows.Forms.Label();
            this.rbQadin = new System.Windows.Forms.RadioButton();
            this.rbKisi = new System.Windows.Forms.RadioButton();
            this.btnElaveEt = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lstTelebeler = new System.Windows.Forms.ListBox();
            this.lblSiyahi = new System.Windows.Forms.Label();
            this.lblTelebeMelumatlari = new System.Windows.Forms.Label();
            this.lblBasliq = new System.Windows.Forms.Label();
            this.lblMelumat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(36, 48);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(27, 16);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(82, 42);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 22);
            this.txtAd.TabIndex = 1;
            // 
            // lblYas
            // 
            this.lblYas.AutoSize = true;
            this.lblYas.Location = new System.Drawing.Point(36, 85);
            this.lblYas.Name = "lblYas";
            this.lblYas.Size = new System.Drawing.Size(34, 16);
            this.lblYas.TabIndex = 2;
            this.lblYas.Text = "Yaş:";
            // 
            // nudYas
            // 
            this.nudYas.Location = new System.Drawing.Point(82, 79);
            this.nudYas.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudYas.Name = "nudYas";
            this.nudYas.Size = new System.Drawing.Size(120, 22);
            this.nudYas.TabIndex = 3;
            this.nudYas.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // lblKurs
            // 
            this.lblKurs.AutoSize = true;
            this.lblKurs.Location = new System.Drawing.Point(36, 122);
            this.lblKurs.Name = "lblKurs";
            this.lblKurs.Size = new System.Drawing.Size(36, 16);
            this.lblKurs.TabIndex = 4;
            this.lblKurs.Text = "Kurs:";
            // 
            // cmbKurs
            // 
            this.cmbKurs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKurs.FormattingEnabled = true;
            this.cmbKurs.Location = new System.Drawing.Point(82, 114);
            this.cmbKurs.Name = "cmbKurs";
            this.cmbKurs.Size = new System.Drawing.Size(121, 24);
            this.cmbKurs.TabIndex = 5;
            // 
            // lblCins
            // 
            this.lblCins.AutoSize = true;
            this.lblCins.Location = new System.Drawing.Point(36, 162);
            this.lblCins.Name = "lblCins";
            this.lblCins.Size = new System.Drawing.Size(36, 16);
            this.lblCins.TabIndex = 6;
            this.lblCins.Text = "Cins:";
            // 
            // rbQadin
            // 
            this.rbQadin.AutoSize = true;
            this.rbQadin.Location = new System.Drawing.Point(82, 160);
            this.rbQadin.Name = "rbQadin";
            this.rbQadin.Size = new System.Drawing.Size(64, 20);
            this.rbQadin.TabIndex = 7;
            this.rbQadin.Text = "Qadın";
            this.rbQadin.UseVisualStyleBackColor = true;
            // 
            // rbKisi
            // 
            this.rbKisi.AutoSize = true;
            this.rbKisi.Location = new System.Drawing.Point(162, 160);
            this.rbKisi.Name = "rbKisi";
            this.rbKisi.Size = new System.Drawing.Size(49, 20);
            this.rbKisi.TabIndex = 8;
            this.rbKisi.Text = "Kişi";
            this.rbKisi.UseVisualStyleBackColor = true;
            // 
            // btnElaveEt
            // 
            this.btnElaveEt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnElaveEt.ForeColor = System.Drawing.Color.White;
            this.btnElaveEt.Location = new System.Drawing.Point(39, 203);
            this.btnElaveEt.Name = "btnElaveEt";
            this.btnElaveEt.Size = new System.Drawing.Size(75, 23);
            this.btnElaveEt.TabIndex = 9;
            this.btnElaveEt.Text = "Əlavə et";
            this.btnElaveEt.UseVisualStyleBackColor = false;
            this.btnElaveEt.Click += new System.EventHandler(this.btnElaveEt_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(136, 203);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lstTelebeler
            // 
            this.lstTelebeler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstTelebeler.FormattingEnabled = true;
            this.lstTelebeler.ItemHeight = 22;
            this.lstTelebeler.Location = new System.Drawing.Point(315, 48);
            this.lstTelebeler.Name = "lstTelebeler";
            this.lstTelebeler.Size = new System.Drawing.Size(410, 180);
            this.lstTelebeler.TabIndex = 11;
            this.lstTelebeler.SelectedIndexChanged += new System.EventHandler(this.lstTelebeler_SelectedIndexChanged);
            // 
            // lblSiyahi
            // 
            this.lblSiyahi.AutoSize = true;
            this.lblSiyahi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSiyahi.Location = new System.Drawing.Point(312, 9);
            this.lblSiyahi.Name = "lblSiyahi";
            this.lblSiyahi.Size = new System.Drawing.Size(161, 25);
            this.lblSiyahi.TabIndex = 12;
            this.lblSiyahi.Text = "Tələbə Siyahısı";
            // 
            // lblTelebeMelumatlari
            // 
            this.lblTelebeMelumatlari.AutoSize = true;
            this.lblTelebeMelumatlari.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTelebeMelumatlari.Location = new System.Drawing.Point(35, 11);
            this.lblTelebeMelumatlari.Name = "lblTelebeMelumatlari";
            this.lblTelebeMelumatlari.Size = new System.Drawing.Size(196, 25);
            this.lblTelebeMelumatlari.TabIndex = 13;
            this.lblTelebeMelumatlari.Text = "Tələbə Məlumatları";
            // 
            // lblBasliq
            // 
            this.lblBasliq.AutoSize = true;
            this.lblBasliq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBasliq.Location = new System.Drawing.Point(311, 243);
            this.lblBasliq.Name = "lblBasliq";
            this.lblBasliq.Size = new System.Drawing.Size(143, 22);
            this.lblBasliq.TabIndex = 14;
            this.lblBasliq.Text = "Seçilən tələbə:";
            this.lblBasliq.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMelumat
            // 
            this.lblMelumat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMelumat.Location = new System.Drawing.Point(314, 286);
            this.lblMelumat.Name = "lblMelumat";
            this.lblMelumat.Size = new System.Drawing.Size(411, 80);
            this.lblMelumat.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.lblMelumat);
            this.Controls.Add(this.lblBasliq);
            this.Controls.Add(this.lblTelebeMelumatlari);
            this.Controls.Add(this.lblSiyahi);
            this.Controls.Add(this.lstTelebeler);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnElaveEt);
            this.Controls.Add(this.rbKisi);
            this.Controls.Add(this.rbQadin);
            this.Controls.Add(this.lblCins);
            this.Controls.Add(this.cmbKurs);
            this.Controls.Add(this.lblKurs);
            this.Controls.Add(this.nudYas);
            this.Controls.Add(this.lblYas);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Name = "Form1";
            this.Text = "Tələbə Qeydiyyat sistemi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudYas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblYas;
        private System.Windows.Forms.NumericUpDown nudYas;
        private System.Windows.Forms.Label lblKurs;
        private System.Windows.Forms.ComboBox cmbKurs;
        private System.Windows.Forms.Label lblCins;
        private System.Windows.Forms.RadioButton rbQadin;
        private System.Windows.Forms.RadioButton rbKisi;
        private System.Windows.Forms.Button btnElaveEt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.ListBox lstTelebeler;
        private System.Windows.Forms.Label lblSiyahi;
        private System.Windows.Forms.Label lblTelebeMelumatlari;
        private System.Windows.Forms.Label lblBasliq;
        private System.Windows.Forms.Label lblMelumat;
    }
}

