using System;
using System.Collections.Generic;
using System.Linq;
using TesteBludataLib.Data;
using TesteBludataLib.Interfaces;
using TesteBludataLib.Models;

namespace TesteBludataLib.Regras
{
    public class FornecedorBLL : IEntity<Fornecedor>
    {
        private static readonly FornecedorMock fornecedorMock = new FornecedorMock();
        public void Alterar(Fornecedor dado)
        {
            dado.Validate(dado.Empresa);

            dado.DataHoraCadastro = LerRegistro(dado.IdFornecedor).DataHoraCadastro;

            fornecedorMock.Alterar(dado);            
        }

        public void Gravar(Fornecedor dado)
        {
            dado.Validate(dado.Empresa);

            dado.DataHoraCadastro = DateTime.Now;

            fornecedorMock.Gravar(dado);
        }

        public List<Fornecedor> Ler()
        {
            return fornecedorMock.Ler().ToList();
        }

        public Fornecedor LerRegistro(int id)
        {
            return fornecedorMock.LerRegistro(id);
        }

        public void Remover(Fornecedor dado)
        {
            fornecedorMock.Remover(dado);
        }
    }
}
