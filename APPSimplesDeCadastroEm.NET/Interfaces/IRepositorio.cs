using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APPSimplesDeCadastroEm.NET.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> Lista();
        T RetornarPorId(int id);
        void Insere(Task entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();


    }
}
