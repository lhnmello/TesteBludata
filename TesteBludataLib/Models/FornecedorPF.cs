using System;
using TesteBludataLib.Exceptions;

namespace TesteBludataLib.Models
{
    public class FornecedorPF : Fornecedor
    {
        public string Rg { get; set; }
        public DateTime DataNascimento { get; set; }

        public override void Validate(Empresa empresa)
        {
            base.Validate(empresa);

            if (CpfCnpj.Length == 0 || CpfCnpj.Trim() == ",   ,   -")
                throw new CampoVazioException("O campo CPF deve ser informado.");

            if (DataNascimento.Date == DateTime.MinValue)
                throw new CampoVazioException("O campo Nascimento deve ser informado.");

            if (Rg.Length == 0)
                throw new CampoVazioException("O campo RG deve ser informado.");

            if (empresa != null)
            {
                if (empresa.Uf == Estado.PR && (DateTime.Now.Year - DataNascimento.Year ) < 18)
                    throw new FornecedorMenorDeIdadeException("Fornecedor " + Nome + " é menor de idade, portanto, não válido para essa empresa.");
            }
        }
    }
}