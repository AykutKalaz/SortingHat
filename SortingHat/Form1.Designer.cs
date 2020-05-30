namespace SortingHat
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.pctResim = new System.Windows.Forms.PictureBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMetin.Location = new System.Drawing.Point(12, 282);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(261, 49);
            this.txtMetin.TabIndex = 0;
            // 
            // pctResim
            // 
            this.pctResim.Location = new System.Drawing.Point(12, 12);
            this.pctResim.Name = "pctResim";
            this.pctResim.Size = new System.Drawing.Size(261, 232);
            this.pctResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctResim.TabIndex = 1;
            this.pctResim.TabStop = false;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(184, 337);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(89, 35);
            this.btnGoster.TabIndex = 2;
            this.btnGoster.Text = "Sonucu Söyle";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nasıl birisin? (cesur, kurnaz, adaletli,mantıklı)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.pctResim);
            this.Controls.Add(this.txtMetin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.PictureBox pctResim;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Label label1;
    }
}

