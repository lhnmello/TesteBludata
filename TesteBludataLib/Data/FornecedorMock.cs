using System;
using System.Collections.Generic;
using System.Linq;
using TesteBludataLib.Interfaces;
using TesteBludataLib.Models;

namespace TesteBludataLib.Data
{
    public class FornecedorMock : IEntity<Fornecedor>
    {
        private readonly List<Fornecedor> fornecedores;

        public FornecedorMock()
        {

            fornecedores = new List<Fornecedor>
            {
                new FornecedorPF()
                {
                    IdFornecedor = 1,
                    Nome = "Luis",
                    CpfCnpj = "111.111.111-11",
                    DataHoraCadastro = DateTime.Now,
                    DataNascimento = new DateTime(1994, 10, 1),
                    Rg = "1.111.111-2",
                    Telefones = new List<string> { "(47)99999-9999", "(48)98888-8888" },
                },

                new FornecedorPF()
                {
                    IdFornecedor = 2,
                    Nome = "Teste",
                    CpfCnpj = "333.333.333-33",
                    DataHoraCadastro = DateTime.Now,
                    DataNascimento = new DateTime(1990, 5, 1),
                    Rg = "4.444.444-4",
                    Telefones = new List<string> { "(47)11111-1111" },
                },

                new FornecedorPJ()
                {
                    IdFornecedor = 3,
                    Nome = "João",
                    CpfCnpj = "21.111.111/0001-15",
                    DataHoraCadastro = DateTime.Now,
                }
            };
        }

        public void Alterar(Fornecedor dado)
        {
            int index = fornecedores.FindIndex(e => e.Equals(dado));

            if (index != -1)
                fornecedores[index] = dado;
        }

        public void Gravar(Fornecedor dado)
        {
            int proximoID;

            if (fornecedores.Count == 0)
                proximoID = 1;
            else
                proximoID = fornecedores[fornecedores.Count - 1].IdFornecedor + 1;

            dado.IdFornecedor = proximoID;

            fornecedores.Add(dado);
        }

        public List<Fornecedor> Ler()
        {
            return fornecedores;
        }

        public Fornecedor LerRegistro(int id)
        {
            return fornecedores.Where(f => f.IdFornecedor == id).FirstOrDefault();
        }

        public void Remover(Fornecedor dado)
        {
            fornecedores.Remove(dado);
        }
    }
}
