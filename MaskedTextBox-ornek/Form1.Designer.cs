namespace MaskedTextBox_ornek
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
            this.lblTC = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.mtTC = new System.Windows.Forms.MaskedTextBox();
            this.mtTarih = new System.Windows.Forms.MaskedTextBox();
            this.mtNumara = new System.Windows.Forms.MaskedTextBox();
            this.mtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mtAdres = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Location = new System.Drawing.Point(12, 20);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(54, 15);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "T.C. No";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(12, 50);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(55, 15);
            this.lblTelefon.TabIndex = 1;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Location = new System.Drawing.Point(12, 82);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(94, 15);
            this.lblTarih.TabIndex = 2;
            this.lblTarih.Text = "Doğum Tarihi";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNumara.Location = new System.Drawing.Point(12, 112);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(99, 15);
            this.lblNumara.TabIndex = 3;
            this.lblNumara.Text = "Kart Numarası";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(12, 144);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(60, 15);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "IP Adres";
            // 
            // mtTC
            // 
            this.mtTC.Location = new System.Drawing.Point(146, 20);
            this.mtTC.Name = "mtTC";
            this.mtTC.Size = new System.Drawing.Size(172, 20);
            this.mtTC.TabIndex = 10;
            this.mtTC.ValidatingType = typeof(int);
            // 
            // mtTarih
            // 
            this.mtTarih.Location = new System.Drawing.Point(146, 82);
            this.mtTarih.Name = "mtTarih";
            this.mtTarih.Size = new System.Drawing.Size(172, 20);
            this.mtTarih.TabIndex = 11;
            this.mtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // mtNumara
            // 
            this.mtNumara.Location = new System.Drawing.Point(146, 112);
            this.mtNumara.Name = "mtNumara";
            this.mtNumara.Size = new System.Drawing.Size(172, 20);
            this.mtNumara.TabIndex = 12;
            // 
            // mtTelefon
            // 
            this.mtTelefon.Location = new System.Drawing.Point(146, 50);
            this.mtTelefon.Name = "mtTelefon";
            this.mtTelefon.Size = new System.Drawing.Size(172, 20);
            this.mtTelefon.TabIndex = 13;
            // 
            // mtAdres
            // 
            this.mtAdres.Location = new System.Drawing.Point(146, 144);
            this.mtAdres.Name = "mtAdres";
            this.mtAdres.Size = new System.Drawing.Size(172, 20);
            this.mtAdres.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtAdres);
            this.Controls.Add(this.mtTelefon);
            this.Controls.Add(this.mtNumara);
            this.Controls.Add(this.mtTarih);
            this.Controls.Add(this.mtTC);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblTC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.MaskedTextBox mtTC;
        private System.Windows.Forms.MaskedTextBox mtTarih;
        private System.Windows.Forms.MaskedTextBox mtNumara;
        private System.Windows.Forms.MaskedTextBox mtTelefon;
        private System.Windows.Forms.MaskedTextBox mtAdres;
    }
}

