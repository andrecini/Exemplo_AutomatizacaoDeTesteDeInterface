using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeAluno
{
    public partial class Cadastro : Form
    {
        private List<Aluno> cadastrados = new List<Aluno>();

        public Cadastro()
        {
            InitializeComponent();

            UpdateNumeroCadastrados();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno aluno = new Aluno(RecebeDados());

                VerificaCadastroRepetido(aluno);

                cadastrados.Add(aluno);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            UpdateNumeroCadastrados();

        }

        private List<string> RecebeDados()
        {
            List<string> dados = new List<string>();

            dados.Add(txtNome.Text);
            dados.Add(mtxtNascimento.Text);
            dados.Add(mtxtTelefone.Text);
            dados.Add(mtxtCPF.Text);
            dados.Add(mtxtUF.Text);
            dados.Add(mtxtRA.Text);
            dados.Add(cbPeriodo.Text);

            return dados;
        }

        private void UpdateNumeroCadastrados()
        {
            lblQtdd.Text = cadastrados.Count().ToString();
        }

        private void VerificaCadastroRepetido(Aluno aluno)
        {
            foreach (var cadastrado in cadastrados)
            {
                if (aluno.CPF == cadastrado.CPF ||
                    aluno.RA == cadastrado.RA)
                    throw new Exception("Esse aluno já foi cadastrado.");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (cadastrados.Count == 0)
                MessageBox.Show("Nenhum dado cadastrado ainda!");
            else
        }
    }
}
