using System.Collections.Generic;
using TesteBludataLib.Exceptions;

namespace TesteBludataLib.Models
{
    public class Empresa
    {
        public Empresa()
        {
            Fornecedores = new List<Fornecedor>();
        }
        public Estado Uf { get; set; }
        public string NomeFantasia { get; set; }
        public string Cnpj { get; set; }
        public List<Fornecedor> Fornecedores { get; set; }

        public void AdicionaFornecedor(Fornecedor fornecedor)
        {
            if (fornecedor != null)
            {
                fornecedor.Validate(this);

                Fornecedores.Add(fornecedor);
            }
        }

        public void RemoveFornecedor(Fornecedor fornecedor)
        {
            if (fornecedor != null)
                Fornecedores.Remove(fornecedor);
        }

        public void Validate()
        {
            if (NomeFantasia.Length == 0)
                throw new CampoVazioException("O campo Nome Fantasia deve ser informado.");

            if (Cnpj.Length == 0)
                throw new CampoVazioException("O campo CNPJ deve ser informado.");

            if (Uf == Estado.Nenhum)
                throw new CampoVazioException("O campo UF deve ser informado.");
        }

        public override string ToString()
        {
            return NomeFantasia;
        }
    }
}
