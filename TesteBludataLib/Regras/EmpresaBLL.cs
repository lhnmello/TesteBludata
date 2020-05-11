using TesteBludataLib.Data;
using TesteBludataLib.Models;

namespace TesteBludataLib.Regras
{
    public class EmpresaBLL 
    {
        private static readonly EmpresaMock empresaMock = new EmpresaMock();

        public void Gravar(Empresa dado)
        {
            EnsureCamposPreenchidos(dado);

            if (dado.Fornecedores != null)
            {
                foreach (var fornecedor in dado.Fornecedores)
                {
                    fornecedor.Validate(dado);
                }
            }

            empresaMock.Gravar(dado);
        }

        public Empresa Ler()
        {
            return empresaMock.Ler();
        }
        
        private void EnsureCamposPreenchidos(Empresa empresa)
        {
            empresa.Validate();
        }
    }
}
