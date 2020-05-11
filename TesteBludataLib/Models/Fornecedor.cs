using System;
using System.Collections.Generic;
using TesteBludataLib.Exceptions;
using TesteBludataLib.Interfaces;

namespace TesteBludataLib.Models
{
	public class Fornecedor : IFornecedor, IComparable<Fornecedor>, IEquatable<Fornecedor>
	{
		public int IdFornecedor { get; set; }
		public Empresa Empresa { get; set; }
		public string Nome { get; set; }
		public virtual string CpfCnpj { get; set; }
		public DateTime DataHoraCadastro { get; set; }
		public List<string> Telefones { get; set; }

		public virtual void Validate(Empresa empresa)
		{
			if (Nome.Length == 0)
				throw new CampoVazioException("O campo Nome deve ser informado.");
		}

		public int CompareTo(Fornecedor other)
		{
			return IdFornecedor.CompareTo(other.IdFornecedor);
		}

		public bool Equals(Fornecedor other)
		{
			return IdFornecedor == other.IdFornecedor;
		}

		public override bool Equals(object obj)
		{
			if (obj is null)
				return false;

			if (ReferenceEquals(this, obj))
				return true;

			if (obj.GetType() != GetType())
				return false;

			return Equals(obj as Fornecedor);
		}

		public override int GetHashCode()
		{
			return IdFornecedor.GetHashCode();
		}

		public override string ToString()
		{
			return Nome;
		}

		public void SetEmpresa(Empresa empresa)
		{
			if (empresa != null)
			{
				Validate(empresa);

				Empresa = empresa;
			}
		}

		public static int OrdenaPorNome(Fornecedor a, Fornecedor b)
		{
			return a.Nome.CompareTo(b.Nome);
		}

		public static int OrdenaPorCpfCnpj(Fornecedor a, Fornecedor b)
		{
			return a.CpfCnpj.CompareTo(b.CpfCnpj);
		}

		public static int OrdenaPorDataCadastro(Fornecedor a, Fornecedor b)
		{
			return a.DataHoraCadastro.CompareTo(b.DataHoraCadastro);
		}
	}
}