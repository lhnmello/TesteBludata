using TesteBludataLib.Exceptions;

namespace TesteBludataLib.Models
{
    public class FornecedorPJ : Fornecedor
    {
        public override void Validate(Empresa empresa)
        {
            base.Validate(empresa);

            if (CpfCnpj.Length == 0 || CpfCnpj.Trim() == ",   ,   /    -")
                throw new CampoVazioException("O campo CNPJ deve ser informado.");
        }
    }
}