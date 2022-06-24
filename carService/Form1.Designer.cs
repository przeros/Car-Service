
namespace carService
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.registrationNumberText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numberOfHoursText = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.partsCostText = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.mechanicComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numer_Rejestracyjny = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Oddania_Samochodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mechanik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Koszt_Czesci_Zamiennych = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Czas_Pracy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Całkowity_Koszt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRepairButton = new System.Windows.Forms.Button();
            this.CarServiceGridView = new System.Windows.Forms.DataGridView();
            this.Nazwa_Warsztatu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zarobki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MechanicGridView = new System.Windows.Forms.DataGridView();
            this.Imie_Mechanika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko_Mechanika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pieniadze = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarServiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // registrationNumberText
            // 
            this.registrationNumberText.Location = new System.Drawing.Point(25, 41);
            this.registrationNumberText.Name = "registrationNumberText";
            this.registrationNumberText.Size = new System.Drawing.Size(200, 23);
            this.registrationNumberText.TabIndex = 0;
            this.registrationNumberText.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numer Rejestracyjny:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data oddania samochodu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mechanik:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(22, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Czas pracy:";
            // 
            // numberOfHoursText
            // 
            this.numberOfHoursText.Location = new System.Drawing.Point(25, 251);
            this.numberOfHoursText.Name = "numberOfHoursText";
            this.numberOfHoursText.Size = new System.Drawing.Size(200, 23);
            this.numberOfHoursText.TabIndex = 8;
            this.numberOfHoursText.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(22, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Koszt części zamiennych:";
            // 
            // partsCostText
            // 
            this.partsCostText.Location = new System.Drawing.Point(25, 194);
            this.partsCostText.Name = "partsCostText";
            this.partsCostText.Size = new System.Drawing.Size(200, 23);
            this.partsCostText.TabIndex = 6;
            this.partsCostText.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(25, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // mechanicComboBox
            // 
            this.mechanicComboBox.FormattingEnabled = true;
            this.mechanicComboBox.Location = new System.Drawing.Point(25, 141);
            this.mechanicComboBox.Name = "mechanicComboBox";
            this.mechanicComboBox.Size = new System.Drawing.Size(200, 21);
            this.mechanicComboBox.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Numer_Rejestracyjny,
            this.Data_Oddania_Samochodu,
            this.Mechanik,
            this.Koszt_Czesci_Zamiennych,
            this.Czas_Pracy,
            this.Całkowity_Koszt});
            this.dataGridView1.Location = new System.Drawing.Point(393, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 150);
            this.dataGridView1.TabIndex = 13;
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
            // Data_Oddania_Samochodu
            // 
            this.Data_Oddania_Samochodu.HeaderText = "Data Oddania Samochodu";
            this.Data_Oddania_Samochodu.Name = "Data_Oddania_Samochodu";
            // 
            // Mechanik
            // 
            this.Mechanik.HeaderText = "Mechanik";
            this.Mechanik.Name = "Mechanik";
            // 
            // Koszt_Czesci_Zamiennych
            // 
            this.Koszt_Czesci_Zamiennych.HeaderText = "Koszt Części Zamiennych";
            this.Koszt_Czesci_Zamiennych.Name = "Koszt_Czesci_Zamiennych";
            // 
            // Czas_Pracy
            // 
            this.Czas_Pracy.HeaderText = "Czas Pracy";
            this.Czas_Pracy.Name = "Czas_Pracy";
            // 
            // Całkowity_Koszt
            // 
            this.Całkowity_Koszt.HeaderText = "Całkowity Koszt";
            this.Całkowity_Koszt.Name = "Całkowity_Koszt";
            // 
            // addRepairButton
            // 
            this.addRepairButton.Location = new System.Drawing.Point(25, 309);
            this.addRepairButton.Name = "addRepairButton";
            this.addRepairButton.Size = new System.Drawing.Size(200, 42);
            this.addRepairButton.TabIndex = 14;
            this.addRepairButton.Text = "Dodaj naprawę";
            this.addRepairButton.UseVisualStyleBackColor = true;
            this.addRepairButton.Click += new System.EventHandler(this.addRepairButton_Click);
            // 
            // CarServiceGridView
            // 
            this.CarServiceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CarServiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nazwa_Warsztatu,
            this.Zarobki});
            this.CarServiceGridView.Location = new System.Drawing.Point(393, 2);
            this.CarServiceGridView.Name = "CarServiceGridView";
            this.CarServiceGridView.Size = new System.Drawing.Size(246, 150);
            this.CarServiceGridView.TabIndex = 15;
            // 
            // Nazwa_Warsztatu
            // 
            this.Nazwa_Warsztatu.HeaderText = "Nazwa Warsztatu";
            this.Nazwa_Warsztatu.Name = "Nazwa_Warsztatu";
            // 
            // Zarobki
            // 
            this.Zarobki.HeaderText = "Zarobki";
            this.Zarobki.Name = "Zarobki";
            // 
            // MechanicGridView
            // 
            this.MechanicGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MechanicGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Imie_Mechanika,
            this.Nazwisko_Mechanika,
            this.Pieniadze});
            this.MechanicGridView.Location = new System.Drawing.Point(793, 2);
            this.MechanicGridView.Name = "MechanicGridView";
            this.MechanicGridView.Size = new System.Drawing.Size(344, 150);
            this.MechanicGridView.TabIndex = 16;
            // 
            // Imie_Mechanika
            // 
            this.Imie_Mechanika.HeaderText = "Imie Mechanika";
            this.Imie_Mechanika.Name = "Imie_Mechanika";
            // 
            // Nazwisko_Mechanika
            // 
            this.Nazwisko_Mechanika.HeaderText = "Nazwisko Mechanika";
            this.Nazwisko_Mechanika.Name = "Nazwisko_Mechanika";
            // 
            // Pieniadze
            // 
            this.Pieniadze.HeaderText = "Pieniądze";
            this.Pieniadze.Name = "Pieniadze";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(404, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MechanicGridView);
            this.Controls.Add(this.CarServiceGridView);
            this.Controls.Add(this.addRepairButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.mechanicComboBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberOfHoursText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.partsCostText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.registrationNumberText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarServiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MechanicGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox registrationNumberText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox numberOfHoursText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox partsCostText;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox mechanicComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addRepairButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numer_Rejestracyjny;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Oddania_Samochodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mechanik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Koszt_Czesci_Zamiennych;
        private System.Windows.Forms.DataGridViewTextBoxColumn Czas_Pracy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Całkowity_Koszt;
        private System.Windows.Forms.DataGridView CarServiceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwa_Warsztatu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zarobki;
        private System.Windows.Forms.DataGridView MechanicGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie_Mechanika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko_Mechanika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pieniadze;
        private System.Windows.Forms.Button button1;
    }
}

