using System;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //estilizar coluna
            //dataGridView1.RowHeadersVisible = false;
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAdicionar form = new FormAdicionar();
            form.DadosCadastro += DadosCadastroAdd;
            DialogResult result = form.ShowDialog();
        }

        private void DadosCadastroAdd(object? sender, DadosCadastroEventArgs e)
        {
            dataGridView1.Rows.Add(e.Tipo, e.Nome, "R$ " + e.Valor);
        }

        //Buscar no DataGridView
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string searchItem = searchBox.Text.ToLower();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value?.ToString()?.ToLower().Contains(searchItem) == true)
                    {
                        int rowIndex = row.Index;
                        dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[0];
                        dataGridView1.Rows[rowIndex].Selected = true;
                        return;
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}