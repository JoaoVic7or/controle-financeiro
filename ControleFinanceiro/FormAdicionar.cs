using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleFinanceiro
{
    public partial class FormAdicionar : Form
    {
        public FormAdicionar()
        {
            InitializeComponent();
            DadosCadastro = delegate { };
        }

        public event EventHandler<DadosCadastroEventArgs> DadosCadastro;

        protected virtual void OnDadosCadastrados(DadosCadastroEventArgs e)
        {
            DadosCadastro?.Invoke(this, e);
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            if (inputNome.Text == "")
            {
                MessageBox.Show("Digite o nome/valor");
            }
            else
            {
                string tipo = "";
                if (radioDespesa.Checked)
                {
                    tipo = "Despesa";
                }
                else if (radioReceita.Checked)
                {
                    tipo = "Receita";
                }
                string nome = inputNome.Text;
                string valor = inputValor.Text;

                DadosCadastroEventArgs args = new DadosCadastroEventArgs(tipo, nome, valor);
                OnDadosCadastrados(args);
                this.Close();
            }
        }

        private void inputValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}