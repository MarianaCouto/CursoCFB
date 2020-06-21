using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_Combobox : Form
    {
        public F_Combobox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cb_transportes.Text,"Transporte selecionado");
        }

        private void btn_limparSelecionado_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_limparElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();
        }

        private void btn_resetarElementos_Click(object sender, EventArgs e)
        {
            cb_transportes.Items.Clear();

            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");

            cb_transportes.Items.AddRange(tr.ToArray());
        }

        private void cb_transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_transporte.Text = cb_transportes.Text;
        }

        private void btn_adicionarTransporte_Click(object sender, EventArgs e)
        {
            if(tb_transporte.Text != "")
            {
                if (cb_transportes.FindString(tb_transporte.Text) < 0)
                {
                    cb_transportes.Items.Add(tb_transporte.Text);
                    tb_transporte.Clear();
                    tb_transporte.Focus();
                }
                else
                {
                    MessageBox.Show(tb_transporte.Text + " já existe!", "Transporte existente");
                }

            }
            else
            {
                MessageBox.Show("Digite um transporte.", "Atenção");
                tb_transporte.Focus();
            }
        }
    }
}
