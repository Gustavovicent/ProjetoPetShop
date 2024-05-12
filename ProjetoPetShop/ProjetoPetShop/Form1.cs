using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPetShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panelLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnimais_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            //pergunta se realmente quer fechar

           if (MessageBox.Show("Deseja mesmo sair ","Super-Cão",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();//Botão Fechar
            }
                    
        }

        private void btnMin_Click(object sender, EventArgs e)

            //Botão Minimizar
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();

            panelSelecao.Top = btnInicio.Top;

            



        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente cliente = new frmCadCliente();
            cliente.TopLevel = false;// não é painel de topo
            cliente.Dock = DockStyle.Fill;//configura o Dock paraabrir a imagem certa no painel
            panelCentral.Controls.Clear();//limpa o painel para não ficar uma aba aberta em cima da outra
            panelCentral.Controls.Add(cliente);//chama o formulario cliente
            cliente.Show();

            //Aplica a posição do eixo X do botão ao panelSeleção

            panelSelecao.Top = btnCliente.Top;
        }
    }
}
