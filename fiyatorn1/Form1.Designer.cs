namespace fiyatorn1
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
            this.txtAlişFiyati = new System.Windows.Forms.TextBox();
            this.txtSatişFiyati = new System.Windows.Forms.TextBox();
            this.btnKarHesaplama = new System.Windows.Forms.Button();
            this.lblToplamKar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(39, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alış Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(39, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Satış Fiyatı";
            // 
            // txtAlişFiyati
            // 
            this.txtAlişFiyati.Location = new System.Drawing.Point(155, 66);
            this.txtAlişFiyati.Name = "txtAlişFiyati";
            this.txtAlişFiyati.Size = new System.Drawing.Size(139, 20);
            this.txtAlişFiyati.TabIndex = 2;
            // 
            // txtSatişFiyati
            // 
            this.txtSatişFiyati.Location = new System.Drawing.Point(155, 104);
            this.txtSatişFiyati.Name = "txtSatişFiyati";
            this.txtSatişFiyati.Size = new System.Drawing.Size(139, 20);
            this.txtSatişFiyati.TabIndex = 3;
            // 
            // btnKarHesaplama
            // 
            this.btnKarHesaplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKarHesaplama.Location = new System.Drawing.Point(155, 154);
            this.btnKarHesaplama.Name = "btnKarHesaplama";
            this.btnKarHesaplama.Size = new System.Drawing.Size(139, 37);
            this.btnKarHesaplama.TabIndex = 4;
            this.btnKarHesaplama.Text = "Kar Hesaplama";
            this.btnKarHesaplama.UseVisualStyleBackColor = true;
            this.btnKarHesaplama.Click += new System.EventHandler(this.btnKarHesaplama_Click);
            // 
            // lblToplamKar
            // 
            this.lblToplamKar.AutoSize = true;
            this.lblToplamKar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblToplamKar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamKar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblToplamKar.Location = new System.Drawing.Point(39, 213);
            this.lblToplamKar.Name = "lblToplamKar";
            this.lblToplamKar.Size = new System.Drawing.Size(141, 24);
            this.lblToplamKar.TabIndex = 5;
            this.lblToplamKar.Text = "TOPLAM KAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(366, 269);
            this.Controls.Add(this.lblToplamKar);
            this.Controls.Add(this.btnKarHesaplama);
            this.Controls.Add(this.txtSatişFiyati);
            this.Controls.Add(this.txtAlişFiyati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlişFiyati;
        private System.Windows.Forms.TextBox txtSatişFiyati;
        private System.Windows.Forms.Button btnKarHesaplama;
        private System.Windows.Forms.Label lblToplamKar;
    }
}

