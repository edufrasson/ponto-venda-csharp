using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDV
{
    public partial class FormVenda : Form
    {
        public FormVenda()
        {
            InitializeComponent();
        }

        double total_venda;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double total_produto = double.Parse(txtQntd.Text) * double.Parse(txtValorUnit.Text);

            // Objeto item (cada linha)
            ListViewItem item = new ListViewItem(txtProduto.Text);

            // Adicionado os valores nas colunas
            item.SubItems.Add(txtQntd.Text);
            item.SubItems.Add(txtValorUnit.Text);
            item.SubItems.Add(total_produto.ToString("C"));

            // Inserindo a linha no objeto da List View
            listView.Items.Add(item);

            this.total_venda += total_produto;

            lblTotal.Text = this.total_venda.ToString("C");

            limparEntradas();
        }

        public void limparEntradas()
        {
            txtProduto.Text = "";
            txtQntd.Text = "";
            txtValorUnit.Text = "";
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            limparEntradas();
            lblTotal.Text = "";
            this.total_venda = 0;
            listView.Items.Clear();
            txtProduto.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
