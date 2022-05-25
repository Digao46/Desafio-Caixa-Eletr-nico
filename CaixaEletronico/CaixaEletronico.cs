using System;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class CaixaEletronico : Form
    {
        public CaixaEletronico()
        {
            InitializeComponent();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt100.Text != "0")
                {
                    txt100.Text = "0";
                }

                if (txt50.Text != "0")
                {
                    txt50.Text = "0";
                }

                if (txt20.Text != "0")
                {
                    txt20.Text = "0";
                }

                if (txt10.Text != "0")
                {
                    txt10.Text = "0";
                }

                if (txt5.Text != "0")
                {
                    txt5.Text = "0";
                }

                if (txt2.Text != "0")
                {
                    txt2.Text = "0";
                }

                string valueWithdraw = txtWithdraw.Text;

                int value = Convert.ToInt32(valueWithdraw);

                if (valueWithdraw != "" && valueWithdraw != "0" && valueWithdraw != "1" && valueWithdraw != "3")
                {
                    if (value >= 100000)
                    {
                        MessageBox.Show("Valor muito alto para saque.");
                    } 
                    else 
                    {
                    int n100 = 0, n50 = 0, n20 = 0, n10 = 0, n5 = 0, n2 = 0;

                        for (int i = 0; i < 1500; i++)
                        {
                            if (value == 111)
                            {
                                txt50.Text = "2";
                                txt5.Text = "1";
                                txt2.Text = "3";
                            }
                            else if (value >= 100)
                            {
                                n100++;
                                value -= 100;
                                txt100.Text = n100.ToString();
                            }
                            else if (value >= 50)
                            {
                                n50++;
                                value -= 50;
                                txt50.Text = n50.ToString();
                            }
                            else if (value >= 20)
                            {
                                n20++;
                                value -= 20;
                                txt20.Text = n20.ToString();
                            }
                            else if (value >= 10)
                            {
                                n10++;
                                value -= 10;
                                txt10.Text = n10.ToString();
                            }
                            else if (value >= 5)
                            {
                                n5++;
                                value -= 5;
                                txt5.Text = n5.ToString();
                            }
                            else if (value >= 2)
                            {
                                n2++;
                                value -= 2;
                                txt2.Text = n2.ToString();
                            }
                        }
                    } 
                }
                else
                {
                    MessageBox.Show("Valor Inválido");
                }
            } catch (Exception)
            {
                MessageBox.Show("Erro! Nenhum valor inserido.");
            }
        }
    }
}