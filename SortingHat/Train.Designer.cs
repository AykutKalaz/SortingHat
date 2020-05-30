namespace SortingHat
{
    partial class Train
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
            this.txtKelime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbList = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKelime
            // 
            this.txtKelime.Location = new System.Drawing.Point(16, 47);
            this.txtKelime.Name = "txtKelime";
            this.txtKelime.Size = new System.Drawing.Size(181, 20);
            this.txtKelime.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Eklemek istediğiniz cümleyi giriniz";
            // 
            // cmbList
            // 
            this.cmbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbList.FormattingEnabled = true;
            this.cmbList.Items.AddRange(new object[] {
            "Gryffindor-Cesurlar",
            "Hufflepuff-Adaletliler",
            "Ravenclaw-Mantıklılar",
            "Slytherin-Kurnazlar"});
            this.cmbList.Location = new System.Drawing.Point(16, 73);
            this.cmbList.Name = "cmbList";
            this.cmbList.Size = new System.Drawing.Size(181, 21);
            this.cmbList.TabIndex = 3;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(16, 100);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(108, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(237, 100);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(108, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test et";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 143);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKelime);
            this.Name = "Train";
            this.Text = "Train";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKelime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbList;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTest;
    }
}