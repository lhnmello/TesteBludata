using System.Collections.Generic;

namespace TesteBludataLib.Interfaces
{
    public interface IEntity<T>
    {
        void Gravar(T dado);
        List<T> Ler();
        T LerRegistro(int id);
        void Alterar(T dado);
        void Remover(T dado);
    }
}
