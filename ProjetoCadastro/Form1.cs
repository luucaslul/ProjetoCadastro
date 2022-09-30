using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                this.Close();
            }


            }
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            foreach(Control item in GrpAluno.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    item.Text = string.Empty;
                }
            }

            foreach(Control item in GrpResponsavel.Controls)
            {
                if (item is TextBox || item is MaskedTextBox)
                {
                    item.Text = string.Empty;
                }
            }

        }

        private void BtnContarAluno_Click(object sender, EventArgs e)
        {

            int count = 0;

            foreach (Control item in GrpAluno.Controls)
            {         
                    count++;
          
            }

            foreach (Control item in GrpMedio.Controls)
            {
                count++;
            }
            foreach (Control item in GrpExtras.Controls)
            {
                count++;
            }


            MessageBox.Show("Você tem " + count + " itens no grupo de alunos");
        }

        private void BtnContarResponsavel_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (Control item in GrpResponsavel.Controls)
            { 
                count++;
            }

            MessageBox.Show("Você tem " + count + " itens no grupo de responsáveis");
        }

        private void BtnContarControles_Click(object sender, EventArgs e)
        {
            int count = 0;

            foreach (Control item in this.Controls)
            {
                count++;
            }

            foreach (Control item in GrpAluno.Controls)
            {
                count++;
            }

            foreach (Control item in GrpResponsavel.Controls)
            {
                count++;
            }

            foreach (Control item in GrpVerificacao.Controls)
            {
                count++;
            }
            foreach (Control item in GrpBtn.Controls)
            {
                count++;
            }





            MessageBox.Show("Você tem " + count + " itens no formulário");
        }

        private void BtnNomes_Click(object sender, EventArgs e)
        {
            String nomes = "";

            foreach (Control item in GrpAluno.Controls)
            {
                nomes += item.Name + " " + Environment.NewLine;

                nomes += item.Text + " ";
            }

            foreach (Control item in GrpResponsavel.Controls)
            {
                nomes += item.Name + " " + Environment.NewLine;

                nomes += item.Text + " ";
            }

            foreach (Control item in GrpVerificacao.Controls)
            {
                nomes += item.Name + " " + Environment.NewLine;

                nomes += item.Text + " ";
            }

            foreach (Control item in GrpBtn.Controls)
            {
                nomes += item.Name + " " + Environment.NewLine;

                nomes += item.Text + " ";
            }

            foreach (Control item in this.Controls)
            {
                nomes += item.Name + " " + Environment.NewLine;

                nomes += item.Text + " ";
            }

            MessageBox.Show("Os nomes dos itens são: " +  nomes);
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("men working");
        }
    }
    }

