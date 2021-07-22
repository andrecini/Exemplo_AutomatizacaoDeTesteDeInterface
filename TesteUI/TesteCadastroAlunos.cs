using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using CadastroDeAluno;
using System.Threading;

namespace TesteUI
{
    [TestClass]
    public partial class TesteCadastroAlunos : Form
    {
        

        [TestMethod]
        public void T0001_SalvaAluno()
        {
            frmCadastro frm = new frmCadastro();

            frm.Show();

            PreencheTela(ref frm);

            frm.btnSalvar.PerformClick();

            frm.Close();
        }

        [TestMethod]
        public void T0002_SalvaArquivo()
        {
            frmCadastro frm = new frmCadastro();

            frm.Show();

            PreencheTela(ref frm);

            frm.btnSalvar.PerformClick();

            //Thread.Sleep(500);

            frm.toolStripButton1.PerformClick();

            frm.Close();
        }


        private void PreencheTela(ref frmCadastro frm)
        {
            //Dados Pessoais
            frm.txtNome.Text = "André Cini";
            frm.mtxtNascimento.Text = "23022001";
            frm.mtxtTelefone.Text = "11987654321";
            frm.mtxtCPF.Text = "12345678901";
            frm.mtxtUF.Text = "SP";
            //Dados Escolares
            frm.mtxtRA.Text = "081200039";
            frm.cbPeriodo.SelectedItem = frm.cbPeriodo.Items[1];
        }
    }
}
