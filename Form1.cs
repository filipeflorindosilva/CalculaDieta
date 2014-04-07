using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculaDieta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            dadospessoa pessoaobj = new dadospessoa(Nomebox.Text, double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text));
            try
            {
                pessoaobj.peso = double.Parse(Pesobox.Text);
                pessoaobj.altura = double.Parse(Alturabox.Text);
                pessoaobj.idade = double.Parse(Idadebox.Text);
                pessoaobj.nome = Nomebox.Text;


                if (radioButton1.Checked && radioButton3.Checked) {
                    Resultado.Text = pessoaobj.nome + System.Environment.NewLine.ToString() + 
                    "Seu gasto calorico basal é de " + Convert.ToString (pessoaobj.ResultadoHomenSedentario (double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text))
                    + " calorias por dia.");
                }

                if (radioButton1.Checked && radioButton4.Checked) {
                    Resultado.Text = pessoaobj.nome + System.Environment.NewLine.ToString() + 
                    "Seu gasto calorico basal é de " + Convert.ToString (pessoaobj.ResultadoHomenLeveAtivo (double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text))
                    + " calorias por dia.");
                }

                if (radioButton1.Checked && radioButton5.Checked) {
                    Resultado.Text = pessoaobj.nome + System.Environment.NewLine.ToString() + 
                    "Seu gasto calorico basal é de " + Convert.ToString (pessoaobj.ResultadoHomenModeradoAtivo (double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text))
                    + " calorias por dia.");
                }

                if (radioButton1.Checked && radioButton6.Checked) {
                    Resultado.Text = pessoaobj.nome + System.Environment.NewLine.ToString() + 
                    "Seu gasto calorico basal é de " + Convert.ToString (pessoaobj.ResultadoHomenAltaAtividade (double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text))
                    + " calorias por dia.");
                }

                if (radioButton1.Checked && radioButton7.Checked) {
                    Resultado.Text = pessoaobj.nome + System.Environment.NewLine.ToString() + 
                    "Seu gasto calorico basal é de " + Convert.ToString (pessoaobj.ResultadoHomenExtremaAtividade (double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text))
                    + " calorias por dia.");
                }

                if (radioButton2.Checked && radioButton3.Checked) {
                    Resultado.Text = pessoaobj.nome + System.Environment.NewLine.ToString() + 
                    "Seu gasto calorico basal é de " + Convert.ToString (pessoaobj.ResultadoMulherSedentaria (double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text))
                    + " calorias por dia.");
                }

                if (radioButton2.Checked && radioButton4.Checked) {
                    Resultado.Text = pessoaobj.nome + System.Environment.NewLine.ToString() + 
                    "Seu gasto calorico basal é de " + Convert.ToString (pessoaobj.ResultadoMulherLeveativa (double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text))
                    + " calorias por dia.");
                }

                if (radioButton2.Checked && radioButton5.Checked) {
                    Resultado.Text = pessoaobj.nome + System.Environment.NewLine.ToString() + 
                    "Seu gasto calorico basal é de " + Convert.ToString (pessoaobj.ResultadoMulherModeradaAtiva (double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text))
                    + " calorias por dia.");
                }

                if (radioButton2.Checked && radioButton6.Checked) {
                    Resultado.Text = pessoaobj.nome + System.Environment.NewLine.ToString() + 
                    "Seu gasto calorico basal é de " + Convert.ToString (pessoaobj.ResultadoMulherAltaAtividade (double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text))
                    + " calorias por dia.");
                }

                if (radioButton2.Checked && radioButton7.Checked) {
                    Resultado.Text = pessoaobj.nome + System.Environment.NewLine.ToString() + 
                    "Seu gasto calorico basal é de " + Convert.ToString (pessoaobj.ResultadoMulherExtremaAtividade (double.Parse(Pesobox.Text), double.Parse(Alturabox.Text), double.Parse(Idadebox.Text))
                    + " calorias por dia.");
                }
            }
            catch (Exception) { }
        
        
        }

    }
}
