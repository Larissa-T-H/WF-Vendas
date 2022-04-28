using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Aula31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                lstProduto.Items.Add(txtProduto.Text);
                lstPreco.Items.Add(txtPreco.Text);
           
            txtProduto.Clear();
            txtPreco.Clear();   

            var somatoria = 0;

            for(int i = 0; i < lstPreco.Items.Count; i++)
            {
                somatoria = somatoria+Convert.ToInt16(lstPreco.Items[i]);
                   
            }
            label3.Text="Total da Compra: "+Convert.ToString(somatoria);

        }
        private void button2_Click(object sender, EventArgs e)
        {

            lstProduto.Items.RemoveAt(lstProduto.SelectedIndex);
            lstPreco.Items.RemoveAt(lstPreco.SelectedIndex);

            var somatoria = 0;
            for (int i = 0; i < lstPreco.Items.Count; i++)
            {
                somatoria = somatoria+Convert.ToInt16(lstPreco.Items[i]);

            }
            label3.Text="Total da Compra: "+Convert.ToString(somatoria);

        }
    }
}
