using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoDeTinta
{
    public partial class frmConsumoDeTinta : Form
    {
        public frmConsumoDeTinta()
        {
            InitializeComponent();
        }

        void getVerificaCampos()
        {
            if(txtAltura.Text != String.Empty && txtRaio.Text != String.Empty && txtCilindro.Text != String.Empty)
            {
                //valores fornecidos por usuario.
                Double raio = Convert.ToDouble(txtRaio.Text);
                Double altura = Convert.ToDouble(txtAltura.Text);
                Double cilindros = Convert.ToDouble(txtCilindro.Text);

                //valores impostos.
                Double lLata = 5;
                Double qtdLitroLata = lLata * 3;
                Double rsLata = 80;

                //medidas.
                Double lateral = 2 * 3.14 * raio * altura;
                Double area = 3.14 * Math.Pow(raio, 2);
                Double areaTotal = lateral + (2 * area); //tamanho da area total em metros quadrados.
                Double qtdLatas = areaTotal / qtdLitroLata; //quantedade de latas por area.
                Double custo = qtdLatas * rsLata;

                //exibição das informações.
                lbLatas.Text = String.Format("{0:N}", qtdLatas) +  "  latas";
                lbPrecoCilindro.Text = "R$  " + String.Format("{0:N}", custo);

                lbTotalLatas.Text = String.Format("{0:N}", qtdLatas * cilindros) + "  latas";
                lbTotalPreco.Text = "R$  " + String.Format("{0:N}", custo * cilindros);
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtCalcular_Click(object sender, EventArgs e)
        {
            getVerificaCampos();
        }

        //evento ao pressionar a tecla enter nos textBox.
        private void TxtAltura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //O código ” !e.Shift” indica que é para mudar para o próximo campo
                //se pressionado ENTER, e ir para o campo anterior se pressionados SHIFT e ENTER simultaneamente
                //(o mesmo funcionamento do SHIFT + TAB).
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
