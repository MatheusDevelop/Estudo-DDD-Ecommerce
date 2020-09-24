using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Services
{
    public class ServiceProduct : IServiceProduct
    {

        //Faz a regra de negocio funcionar na pratica 

        private readonly IProduct _IProduct;
        public ServiceProduct(IProduct IProduct)
        {
            _IProduct = IProduct;
        }

        public void AddProduto(Produto p)
        {
            var nomeIsValid = p.ValidarString(p.Nome, "Nome");
            var valorIsValid = p.ValidarDecimal(p.Valor, "Valor");

            if(nomeIsValid && valorIsValid)
            {
                p.Estado = true;
                _IProduct.Add(p);
            }
        }

        public void UpdateProduto(Produto p)
        {
            var nomeIsValid = p.ValidarString(p.Nome, "Nome");
            var valorIsValid = p.ValidarDecimal(p.Valor, "Valor");

            if (nomeIsValid && valorIsValid)
            {                
                _IProduct.Update(p);
            }
        }
    }
}
