using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CadastroDeAluno.Classes
{
    public class Escritor
    {
        public static void SalvaArquivo(List<Aluno> cadastrados)
        {
            if (!Directory.Exists(@"\AlunosCadastrados"))
                Directory.CreateDirectory(@"\AlunosCadastrados");

            File.WriteAllText("Registros", FormataConteudo(cadastrados));
        }

        private static string FormataConteudo(List<Aluno> cadastrados)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var a in cadastrados)
            {
                sb.AppendLine(string.Format("Nome: {0}", a.Nome));
                sb.AppendLine(string.Format("Data de Nascimento: {0}", a.Nascimento));
                sb.AppendLine(string.Format("Telefone: {0}", a.Telefone));
                sb.AppendLine(string.Format("CPF: {0}", a.CPF));
                sb.AppendLine(string.Format("UF: {0}", a.UF));
                sb.AppendLine(string.Format("RA: {0}", a.RA));
                sb.AppendLine(string.Format("Período: {0}", a.Periodo));
                sb.AppendLine("\n");
            }

            return sb.ToString();

        }
    }
}
