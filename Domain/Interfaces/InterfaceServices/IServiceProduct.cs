using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.InterfaceServices
{
    public interface IServiceProduct
    {
        //Metodos adicionais da regra de negocio
        void AddProduto(Produto p);
        void UpdateProduto(Produto p);
    }
}
