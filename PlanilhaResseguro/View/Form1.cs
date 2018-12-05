using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using PlanilhaResseguro.Presenter;

namespace PlanilhaResseguro
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void Button1_Click(object sender, EventArgs e)
        {
            string path = null;
            string pathSaida = @"C:\Users\matheusmr\Downloads\Movimentos de Sinistro.xlsx";
            string fileName = null;
            bool sucess = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
                fileName = openFileDialog1.SafeFileName;
                MessageBox.Show($@"Arquivo {fileName} carregado com sucesso!!");
                sr.Close();
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show(@"Por favor preencha o número/ID do Jira!", @"Número do Jira", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sucess = PlanilhaResseguroPresenter.PlanilhaSinistro(path, pathSaida, textBox1.Text);
            }
            if (sucess)
            {
                FinalizouArquivoSucesso(pathSaida);
            }
            else
            {
                FinalizouArquivoErro(pathSaida);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string path = null;
            string fileName = null;
            string pathSaida = @"C:\Users\matheusmr\Downloads\Movimentos Resseguro Prêmio.xlsx";
            bool sucess = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                path = openFileDialog1.FileName;
                fileName = openFileDialog1.SafeFileName;
                MessageBox.Show($@"Arquivo {fileName} carregado com sucesso!!");
                sr.Close();
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show(@"Por favor preencha o número/ID do Jira!", @"Número do Jira", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sucess = PlanilhaResseguroPresenter.PlanilhaResseguroPremio(path, pathSaida, textBox1.Text);
            }
            if (sucess)
            {
                FinalizouArquivoSucesso(pathSaida);
            }
            else
            {
                FinalizouArquivoErro(pathSaida);
            }
        }
        public static void FinalizouArquivoSucesso(string pathExcel)
        {
            MessageBox.Show($@"Arquivo gerado no caminho: {pathExcel} ", @"Arquivo gerado com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void FinalizouArquivoErro(string pathExcel)
        {
            MessageBox.Show($@"Arquivo não foi gerado!", @"Erro a o processar!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
