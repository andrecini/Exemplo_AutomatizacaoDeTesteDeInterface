using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroDeAluno
{
    public class Aluno
    {
        #region Encapsulamento

        private string _nome;
        private string _nascimento;
        private string _telefone;
        private string _cpf;
        private string _uf;
        private string _ra;
        private string _periodo;

        #endregion

        #region Propriedades
        public string Nome
        {
            get => _nome;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo 'Nome' não foi preenchido corretamente!");
                else
                    _nome = value;
            }
        }

        public string Nascimento
        {
            get => _nascimento;
            set
            {
                _nascimento = value;
            }
        }

        public string Telefone
        {
            get => _telefone;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo 'Telefone' não foi preenchido corretamente!");
                else
                    _telefone = value;
            }
        }

        public string CPF
        {
            get => _cpf;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo 'CPF' não foi preenchido corretamente!");
                else
                    _cpf = value;
            }
        }

        public string UF
        {
            get => _uf;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo 'UF' não foi preenchido corretamente!");
                else
                    _uf = value;
            }
        }

        public string RA
        {
            get => _ra;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo 'RA' não foi preenchido corretamente!");
                else
                    _ra = value;
            }
        }

        public string Periodo
        {
            get => _periodo;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo 'Periodo' não foi preenchido corretamente!");
                else
                    _periodo = value;
            }
        }
        #endregion

        #region Construtores

        public Aluno() { }

        public Aluno(ICollection<string> dados)
        {
            Nome = dados.ElementAt(0);
            Nascimento = dados.ElementAt(1);
            Telefone = dados.ElementAt(2);
            CPF = dados.ElementAt(3);
            UF = dados.ElementAt(4);
            RA = dados.ElementAt(5);
            Periodo = dados.ElementAt(6);
        }

        #endregion

    }
}
