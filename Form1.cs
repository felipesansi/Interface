using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ContaCorrente ContaCorrente = new ContaCorrente();

        private void btn_criar_Click(object sender, EventArgs e)
        {
            ContaCorrente.Agencia =txt_agencia.Text;
            ContaCorrente.numero = txt_conta.Text;
            ContaCorrente.Titular =txt_titular.Text;
            ContaCorrente.Saldo = double.Parse(txt_saldo.Text);
            ContaCorrente.limite = 500;
            MessageBox.Show("Sua conta foi criada com sucesso!","Mensagem",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn_depositar_Click(object sender, EventArgs e)
        {
            ContaCorrente.Depositar(double.Parse(txt_valor.Text));
            txt_saldo.Text = ContaCorrente.Saldo.ToString();
            txt_saldo.Text = null;
        }

        private void btn_sacar_Click(object sender, EventArgs e)
        {
            ContaCorrente.Sacar(double.Parse(txt_valor.Text));
            txt_saldo.Text = ContaCorrente.Saldo.ToString();
            txt_saldo.Text = null;

        }

        private void btn_exibir_saldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Titular: " +ContaCorrente.Titular+"\nAgência: " +ContaCorrente.Agencia+ "Número da conta: "+ContaCorrente.numero+"\nSaldo: "+ContaCorrente.Saldo.ToString("C")+"\nValor do juros: "+ContaCorrente.Calcular().ToString("C"));
        }
    }
}
