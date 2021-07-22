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
        

        [TestMethod, TestCategory("Preenchimento")]
        public void T0001_SalvaAluno()
        {
            frmCadastro frm = new frmCadastro();

            frm.Show();

            PreencheTela(ref frm);

            frm.btnSalvar.PerformClick();

            frm.Close();
        }

        [TestMethod, TestCategory("Salvar Arquivo")]
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

        [TestMethod, TestCategory("Salvar Arquivo")]
        public void T0003_SalvaVariosAlunosNoArquivo()
        {
            frmCadastro frm = new frmCadastro();

            frm.Show();

            CriaVariosAlunos(ref frm);

            Thread.Sleep(2000);

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

        private void CriaVariosAlunos(ref frmCadastro frm)
        {

            #region Aluno 1
            frm.txtNome.Text = "Aluno 1";
            frm.mtxtNascimento.Text = "11111111";
            frm.mtxtTelefone.Text = "11111111111";
            frm.mtxtCPF.Text = "11111111111";
            frm.mtxtUF.Text = "AA";
            frm.mtxtRA.Text = "111111111";
            frm.cbPeriodo.SelectedItem = frm.cbPeriodo.Items[0];

            frm.btnSalvar.PerformClick();
            #endregion

            #region Aluno 2
            frm.txtNome.Text = "Aluno 2";
            frm.mtxtNascimento.Text = "22222222";
            frm.mtxtTelefone.Text = "22222222222";
            frm.mtxtCPF.Text = "22222222222";
            frm.mtxtUF.Text = "BB";
            frm.mtxtRA.Text = "222222222";
            frm.cbPeriodo.SelectedItem = frm.cbPeriodo.Items[1];

            frm.btnSalvar.PerformClick();
            #endregion

            #region Aluno 3
            frm.txtNome.Text = "Aluno 3";
            frm.mtxtNascimento.Text = "3333333";
            frm.mtxtTelefone.Text = "3333333333";
            frm.mtxtCPF.Text = "33333333333";
            frm.mtxtUF.Text = "CC";
            frm.mtxtRA.Text = "333333333";
            frm.cbPeriodo.SelectedItem = frm.cbPeriodo.Items[0];

            frm.btnSalvar.PerformClick();
            #endregion

            #region Aluno 4
            frm.txtNome.Text = "Aluno 4";
            frm.mtxtNascimento.Text = "44444444";
            frm.mtxtTelefone.Text = "44444444444";
            frm.mtxtCPF.Text = "44444444444";
            frm.mtxtUF.Text = "DD";
            frm.mtxtRA.Text = "444444444";
            frm.cbPeriodo.SelectedItem = frm.cbPeriodo.Items[1];

            frm.btnSalvar.PerformClick();
            #endregion

        }
    }
}
