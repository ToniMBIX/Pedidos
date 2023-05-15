using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pedidos
{
    public partial class Menu : Form
    {
        int totalPack = 0;
        int pack1 = 0;
        int pack2 = 0;
        int pack3 = 0;
        int maxPack = 5;
        public Menu()
        {
            InitializeComponent();
            textBoxHamburguesa.TextChanged += (sender, e) => SacarTotal();
            textBoxPapas.TextChanged += (sender, e) => SacarTotal();
            textBoxRefresco.TextChanged += (sender, e) => SacarTotal();
            textBoxPizza.TextChanged += (sender, e) => SacarTotal();
            textBoxNugget.TextChanged += (sender, e) => SacarTotal();
            textBoxEnsalada.TextChanged += (sender, e) => SacarTotal();
            textBoxYogur.TextChanged += (sender, e) => SacarTotal();
            textBoxAgua.TextChanged += (sender, e) => SacarTotal();
            textBoxHamburguesa.TextChanged += (sender, e) => SacarIVA();
            textBoxPapas.TextChanged += (sender, e) => SacarIVA();
            textBoxRefresco.TextChanged += (sender, e) => SacarIVA();
            textBoxPizza.TextChanged += (sender, e) => SacarIVA();
            textBoxNugget.TextChanged += (sender, e) => SacarIVA();
            textBoxEnsalada.TextChanged += (sender, e) => SacarIVA();
            textBoxYogur.TextChanged += (sender, e) => SacarIVA();
            textBoxAgua.TextChanged += (sender, e) => SacarIVA();
            textBoxHamburguesa.TextChanged += (sender, e) => SacarPrecioTotal();
            textBoxPapas.TextChanged += (sender, e) => SacarPrecioTotal();
            textBoxRefresco.TextChanged += (sender, e) => SacarPrecioTotal();
            textBoxPizza.TextChanged += (sender, e) => SacarPrecioTotal();
            textBoxNugget.TextChanged += (sender, e) => SacarPrecioTotal();
            textBoxEnsalada.TextChanged += (sender, e) => SacarPrecioTotal();
            textBoxYogur.TextChanged += (sender, e) => SacarPrecioTotal();
            textBoxAgua.TextChanged += (sender, e) => SacarPrecioTotal();

            float sacarValor(Label label)
            {
                string labelText = label.Text.Replace("€", "").Trim();
                return float.Parse(labelText);
            }
            void SacarTotal()
            {
                float total = 0;
                total += float.Parse(textBoxHamburguesa.Text) * sacarValor(labelPrecioHamburguesa);
                total += float.Parse(textBoxPapas.Text) * sacarValor(labelPrecioPapas);
                total += float.Parse(textBoxRefresco.Text) * sacarValor(labelPrecioRefresco);
                total += float.Parse(textBoxPizza.Text) * sacarValor(labelPrecioPizza);
                total += float.Parse(textBoxNugget.Text) * sacarValor(labelPrecioNugget);
                total += float.Parse(textBoxEnsalada.Text) * sacarValor(labelPrecioEnsalada);
                total += float.Parse(textBoxYogur.Text) * sacarValor(labelPrecioYogur);
                total += float.Parse(textBoxAgua.Text) * sacarValor(labelPrecioAgua);
                this.textBoxSubTotal.Text = total.ToString("F2")+" €";
            }
            void SacarIVA()
            {
                float IVA = (float.Parse(textBoxSubTotal.Text.Substring(0, textBoxSubTotal.Text.Length - 1)) * 0.16f);
                this.textBoxIVA.Text = IVA.ToString("F2")+" €";
            }
            void SacarPrecioTotal()
            {
                float total = (float.Parse(textBoxSubTotal.Text.Substring(0, textBoxSubTotal.Text.Length - 1)) + float.Parse(textBoxIVA.Text.Substring(0, textBoxIVA.Text.Length - 1)));
                this.textBoxTotal.Text = total.ToString("F2") + " €";
            }
        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxPack4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPack4.Checked==true)
            {
                checkBoxPack1.Checked = false;
                checkBoxPack2.Checked = false;
                checkBoxPack3.Checked = false;
                buttonAgregarHamburguesa.Visible = true;
                buttonQuitarHamburguesa.Visible = true;
                buttonAgregarPapas.Visible = true;
                buttonQuitarPapas.Visible = true;
                buttonAgregarRefresco.Visible = true;
                buttonQuitarRefresco.Visible = true;
                buttonAgregarPizza.Visible = true;
                buttonQuitarPizza.Visible = true;
                buttonAgregarNugget.Visible = true;
                buttonQuitarNugget.Visible = true;
                buttonAgregarEnsalada.Visible = true;
                buttonQuitarEnsalada.Visible = true;
                buttonAgregarYogur.Visible = true;
                buttonQuitarYogur.Visible = true;
                buttonAgregarAgua.Visible = true;
                buttonQuitarAgua.Visible = true;
            }
            else
            {
                buttonAgregarHamburguesa.Visible = false;
                buttonQuitarHamburguesa.Visible = false;
                buttonAgregarPapas.Visible = false;
                buttonQuitarPapas.Visible = false;
                buttonAgregarRefresco.Visible = false;
                buttonQuitarRefresco.Visible = false;
                buttonAgregarPizza.Visible = false;
                buttonQuitarPizza.Visible = false;
                buttonAgregarNugget.Visible = false;
                buttonQuitarNugget.Visible = false;
                buttonAgregarEnsalada.Visible = false;
                buttonQuitarEnsalada.Visible = false;
                buttonAgregarYogur.Visible = false;
                buttonQuitarYogur.Visible = false;
                buttonAgregarAgua.Visible = false;
                buttonQuitarAgua.Visible = false;

            }
        }

        private void checkBoxPack1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPack1.Checked == true)
            {
                checkBoxPack2.Checked = false;
                checkBoxPack3.Checked = false;
                checkBoxPack4.Checked = false;
                buttonAgregarPack1.Enabled = true;
                buttonQuitarPack1.Enabled = true;
            }
            else
            {
                buttonAgregarPack1.Enabled = false;
                buttonQuitarPack1.Enabled = false;
            }
        }

        private void checkBoxPack2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPack2.Checked == true)
            {
                checkBoxPack1.Checked = false;
                checkBoxPack3.Checked = false;
                checkBoxPack4.Checked = false;
                buttonAgregarPack2.Enabled = true;
                buttonQuitarPack2.Enabled = true;
            }
            else
            {
                buttonAgregarPack2.Enabled = false;
                buttonQuitarPack2.Enabled = false;
            }

        }

        private void checkBoxPack3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxPack3.Checked == true)
            {
                checkBoxPack2.Checked = false;
                checkBoxPack1.Checked = false;
                checkBoxPack4.Checked = false;
                buttonAgregarPack3.Enabled = true;
                buttonQuitarPack3.Enabled = true;
            }
            else
            {
                buttonAgregarPack3.Enabled = false; 
                buttonQuitarPack3.Enabled = false;
            }
        }

        private void buttonAgregarPack1_Click(object sender, EventArgs e)
        {
            if (totalPack < maxPack)
            {
                totalPack++;
                pack1++;
                textBoxHamburguesa.Text = (int.Parse(textBoxHamburguesa.Text)+1).ToString();
                textBoxPapas.Text = (int.Parse(textBoxPapas.Text)+1).ToString();
                textBoxRefresco.Text = (int.Parse(textBoxRefresco.Text)+1).ToString();
            }
            else
            {
                MessageBox.Show("Este pedido ya tiene el limite máximo de paquetes permitido por pedido(5)");
            }
        }

        private void buttonQuitarPack1_Click(object sender, EventArgs e)
        {
            if (pack1 == 0)
            {
                MessageBox.Show("Este paquete no está agregado al pedido");
            }
            else
            {
                pack1--;
                totalPack--;
                textBoxHamburguesa.Text = (int.Parse(textBoxHamburguesa.Text) - 1).ToString();
                textBoxPapas.Text = (int.Parse(textBoxPapas.Text) - 1).ToString();
                textBoxRefresco.Text = (int.Parse(textBoxRefresco.Text) - 1).ToString();
            }
        }

        private void buttonAgregarPack2_Click(object sender, EventArgs e)
        {
            if (totalPack < maxPack)
            {
                totalPack++;
                pack2++;
                textBoxPizza.Text = (int.Parse(textBoxPizza.Text) + 1).ToString();
                textBoxNugget.Text = (int.Parse(textBoxNugget.Text) + 1).ToString();
                textBoxRefresco.Text = (int.Parse(textBoxRefresco.Text) + 1).ToString();
            }
            else
            {
                MessageBox.Show("Este pedido ya tiene el limite máximo de paquetes permitido por pedido(5)");
            }
        }

        private void buttonQuitarPack2_Click(object sender, EventArgs e)
        {
            if (pack2 == 0)
            {
                MessageBox.Show("Este paquete no está agregado al pedido");
            }
            else
            {
                pack2--;
                totalPack--;
                textBoxPizza.Text = (int.Parse(textBoxPizza.Text) - 1).ToString();
                textBoxNugget.Text = (int.Parse(textBoxNugget.Text) - 1).ToString();
                textBoxRefresco.Text = (int.Parse(textBoxRefresco.Text) - 1).ToString();
            }
        }

        private void buttonAgregarPack3_Click(object sender, EventArgs e)
        {
            if (totalPack < maxPack)
            {
                totalPack++;
                pack3++;
                textBoxEnsalada.Text = (int.Parse(textBoxEnsalada.Text) + 1).ToString();
                textBoxYogur.Text = (int.Parse(textBoxYogur.Text) + 1).ToString();
                textBoxAgua.Text = (int.Parse(textBoxAgua.Text) + 1).ToString();
            }
            else
            {
                MessageBox.Show("Este pedido ya tiene el limite máximo de paquetes permitido por pedido(5)");
            }

        }

        private void buttonQuitarPack3_Click(object sender, EventArgs e)
        {
            if (pack3 == 0)
            {
                MessageBox.Show("Este paquete no está agregado al pedido");
            }
            else
            {
                pack3--;
                totalPack--;
                textBoxEnsalada.Text = (int.Parse(textBoxEnsalada.Text) - 1).ToString();
                textBoxYogur.Text = (int.Parse(textBoxYogur.Text) - 1).ToString();
                textBoxAgua.Text = (int.Parse(textBoxAgua.Text) - 1).ToString();
            }

        }
        private void textBoxPago_TextChanged(object sender, EventArgs e)
        {
            string simbolo = " €";
            if (!textBoxPago.Text.EndsWith(simbolo))
            {
                textBoxPago.Text += simbolo;
                textBoxPago.SelectionStart = textBoxPago.Text.Length - 1;
            }
        }

        private void buttonAgregarHamburguesa_Click(object sender, EventArgs e)
        {
            textBoxHamburguesa.Text = (int.Parse(textBoxHamburguesa.Text) + 1).ToString();
        }

        private void buttonQuitarHamburguesa_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxHamburguesa.Text)>0)
            {
                textBoxHamburguesa.Text = (int.Parse(textBoxHamburguesa.Text) - 1).ToString();
            }
        }

        private void buttonAgregarPapas_Click(object sender, EventArgs e)
        {
            textBoxPapas.Text = (int.Parse(textBoxPapas.Text) + 1).ToString();
        }

        private void buttonQuitarPapas_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxPapas.Text) > 0)
            {
                textBoxPapas.Text = (int.Parse(textBoxPapas.Text) - 1).ToString();
            }
        }

        private void buttonAgregarRefresco_Click(object sender, EventArgs e)
        {
            textBoxRefresco.Text = (int.Parse(textBoxRefresco.Text) + 1).ToString();
        }

        private void buttonQuitarRefresco_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxRefresco.Text) > 0)
            {
                textBoxRefresco.Text = (int.Parse(textBoxRefresco.Text) - 1).ToString();
            }
        }

        private void buttonAgregarPizza_Click(object sender, EventArgs e)
        {
            textBoxPizza.Text = (int.Parse(textBoxPizza.Text) + 1).ToString();
        }

        private void buttonQuitarPizza_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxPizza.Text) > 0)
            {
                textBoxPizza.Text = (int.Parse(textBoxPizza.Text) - 1).ToString();
            }
        }

        private void buttonAgregarNugget_Click(object sender, EventArgs e)
        {
            textBoxNugget.Text = (int.Parse(textBoxNugget.Text) + 1).ToString();
        }

        private void buttonQuitarNugget_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxNugget.Text) > 0)
            {
                textBoxNugget.Text = (int.Parse(textBoxNugget.Text) - 1).ToString();
            }
        }

        private void buttonAgregarEnsalada_Click(object sender, EventArgs e)
        {
            textBoxEnsalada.Text = (int.Parse(textBoxEnsalada.Text) + 1).ToString();
        }

        private void buttonQuitarEnsalada_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxEnsalada.Text) > 0)
            {
                textBoxEnsalada.Text = (int.Parse(textBoxEnsalada.Text) - 1).ToString();
            }
        }

        private void buttonAgregarYogur_Click(object sender, EventArgs e)
        {
            textBoxYogur.Text = (int.Parse(textBoxYogur.Text) + 1).ToString();
        }

        private void buttonQuitarYogur_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxYogur.Text) > 0)
            {
                textBoxYogur.Text = (int.Parse(textBoxYogur.Text) - 1).ToString();
            }
        }

        private void buttonAgregarAgua_Click(object sender, EventArgs e)
        {
            textBoxAgua.Text = (int.Parse(textBoxAgua.Text) + 1).ToString();
        }

        private void buttonQuitarAgua_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxAgua.Text) > 0)
            {
                textBoxAgua.Text = (int.Parse(textBoxAgua.Text) - 1).ToString();
            }
        }

        private void buttonPagar_Click(object sender, EventArgs e)
        {
            if (textBoxPostal.Text!=string.Empty && float.Parse(textBoxPago.Text.Substring(0, textBoxPago.Text.Length - 1)) > float.Parse(textBoxTotal.Text.Substring(0, textBoxTotal.Text.Length - 1)))
            {
                float cambio = (float.Parse(textBoxPago.Text.Substring(0, textBoxPago.Text.Length - 1)) - float.Parse(textBoxTotal.Text.Substring(0, textBoxTotal.Text.Length - 1)));
                this.textBoxCambio.Text = cambio.ToString("F2") + " €";

            }
            if (textBoxPostal.Text == string.Empty)
            {
                MessageBox.Show("Debes introducir un codigo postal");
            }
            if(float.Parse(textBoxPago.Text.Substring(0, textBoxPago.Text.Length - 1)) < float.Parse(textBoxTotal.Text.Substring(0, textBoxTotal.Text.Length - 1)))
            {
                MessageBox.Show("Dinero insuficiente");
            }
        }

        private void buttonNuevaOperacion_Click(object sender, EventArgs e)
        {
            totalPack = 0;
            textBoxHamburguesa.Text = "0";
            textBoxPapas.Text = "0";
            textBoxRefresco.Text = "0";
            textBoxPizza.Text = "0";
            textBoxNugget.Text = "0";
            textBoxEnsalada.Text = "0";
            textBoxYogur.Text = "0";
            textBoxAgua.Text = "0";
            textBoxPago.Text = "0,00 €";
            textBoxCambio.Text = "0,00 €";
        }
    }
}
