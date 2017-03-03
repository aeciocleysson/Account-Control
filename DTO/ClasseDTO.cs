using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_Control.DTO
{
    class ClasseDTO
    {
        // ATRIBUTOS DA CONTA

        int idConta, empresa;
        double valor;
        DateTime vencimento;
        string descConta;

        // ATRIBUTOS DA EMPRESA

        int idEmpresa;
        string nome, telefone, descEmpresa;

        // MÉTODOS GET SET

        public int IdConta
        {
            get { return idConta; }

            set { idConta = value; }
        }

        public int Empresa
        {
            get { return empresa; }

            set { empresa = value; }
        }

        public double Valor
        {
            get { return valor; }

            set { valor = value; }
        }

        public DateTime Vencimento
        {
            get { return vencimento; }

            set { vencimento = value; }
        }

        public string DescConta
        {
            get { return descConta; }

            set { descConta = value; }
        }

        public int IdEmpresa
        {
            get { return idEmpresa; }

            set { idEmpresa = value; }
        }

        public string Nome
        {
            get { return nome; }

            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }

            set { telefone = value; }
        }

        public string DescEmpresa
        {
            get { return descEmpresa; }

            set { descEmpresa = value; }
        }
    }
}
