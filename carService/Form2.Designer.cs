
namespace carService
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numer_Rejestracyjny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Oddania_Samochody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mechanik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koszt_Czesci_Zamiennych = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Czas_Pracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calkowity_Koszt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.percentAllRepairs = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Numer_Rejestracyjny,
            this.Data_Oddania_Samochody,
            this.Mechanik,
            this.Koszt_Czesci_Zamiennych,
            this.Czas_Pracy,
            this.Calkowity_Koszt});
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Numer_Rejestracyjny
            // 
            this.Numer_Rejestracyjny.HeaderText = "Numer Rejestracyjny";
            this.Numer_Rejestracyjny.Name = "Numer_Rejestracyjny";
            // 
            // Data_Oddania_Samochody
            // 
            this.Data_Oddania_Samochody.HeaderText = "Data Oddania Samochody";
            this.Data_Oddania_Samochody.Name = "Data_Oddania_Samochody";
            // 
            // Mechanik
            // 
            this.Mechanik.HeaderText = "Mechanik";
            this.Mechanik.Name = "Mechanik";
            // 
            // Koszt_Czesci_Zamiennych
            // 
            this.Koszt_Czesci_Zamiennych.HeaderText = "Koszt Czesci Zamiennych";
            this.Koszt_Czesci_Zamiennych.Name = "Koszt_Czesci_Zamiennych";
            // 
            // Czas_Pracy
            // 
            this.Czas_Pracy.HeaderText = "Czas Pracy";
            this.Czas_Pracy.Name = "Czas_Pracy";
            // 
            // Calkowity_Koszt
            // 
            this.Calkowity_Koszt.HeaderText = "Całkowity Koszt";
            this.Calkowity_Koszt.Name = "Calkowity_Koszt";
            // 
            // percentAllRepairs
            // 
            this.percentAllRepairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.percentAllRepairs.Location = new System.Drawing.Point(256, 253);
            this.percentAllRepairs.Name = "percentAllRepairs";
            this.percentAllRepairs.Size = new System.Drawing.Size(219, 62);
            this.percentAllRepairs.TabIndex = 1;
            this.percentAllRepairs.Text = "";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 450);
            this.Controls.Add(this.percentAllRepairs);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numer_Rejestracyjny;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Oddania_Samochody;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mechanik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koszt_Czesci_Zamiennych;
        private System.Windows.Forms.DataGridViewTextBoxColumn Czas_Pracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calkowity_Koszt;
        private System.Windows.Forms.RichTextBox percentAllRepairs;
    }
}