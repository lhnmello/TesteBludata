using TesteBludataLib.Models;

namespace TesteBludataLib.Data
{
    public class EmpresaMock
    {
        private Empresa empresa;

        public EmpresaMock()
        {
            empresa = new Empresa()
            {
                Cnpj = "44.444.333/0001-15",
                NomeFantasia = "Empresa teste",
                Uf = Estado.MS
            };
        }

        public void Gravar(Empresa dado)
        {
            empresa = dado;
        }

        public Empresa Ler()
        {
            return empresa;
        }
    }
}
