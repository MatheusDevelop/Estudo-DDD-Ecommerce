using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface InterfaceProductApp:InterfaceGenericsApp<Produto>
    {
        //Metodos adicionais da regra de negocio que ficará disponibilizado tbm
        void AddProduto(Produto p);
        void UpdateProduto(Produto p);
    }
}
