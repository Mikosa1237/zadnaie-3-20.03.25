using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace zadnaie_3_20._03._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Inicjalizacja DataGridView
            DataGridView dataGridView1 = new DataGridView();
            dataGridView1.Dock = DockStyle.Fill;
            // Utworzenie kolumn
            dataGridView1.Columns.Add("Column1", "Column 1");
            dataGridView1.Columns.Add("Column2", "Column 2");
            dataGridView1.Columns.Add("Column3", "Column 3");
            dataGridView1.Columns.Add("Column4", "Column 4");
            // Dodanie danych do siatki
            dataGridView1.Rows.Add(new object[] { "Data 1", "Value 1" });
            dataGridView1.Rows.Add(new object[] { "Data 2", "Value 2" });
            dataGridView1.Rows.Add(new object[] { "Data 3", "Value 3" });
            dataGridView1.Rows.Add(new object[] { "Data 4", "Value 4" });
            // Dodanie DataGridView do formularza
            Controls.Add(dataGridView1);
        }

        private void but_add_Click(object sender, EventArgs e)
        {

        }

        private void but_del_Click(object sender, EventArgs e)
        {

        }

        private void but_zap_Click(object sender, EventArgs e)
        {

        }

        private void but_od_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy plik istnieje
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error)return;
            }
            // Odczytaj zawartość pliku CSV
            string[] lines = File.ReadAllLines(filePath);
            // Tworzenie tabeli danych
            DataTable dataTable = new DataTable();
            // Dodanie kolumn na podstawie nagłówka
            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }
            // Dodawanie wierszy do tabeli danych
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                dataTable.Rows.Add(values);
            }
            // Przypisanie tabeli danych do DataGridView
            dataGridView1.DataSource = dataTable;
        }
    }
}
