using Application.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;


namespace Application.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        //Pega a interface do domain pra poder ter acesso ao crud de produtos
        IProduct _IProduct;
        //pega a interface do domain pra poder ter acesso aos novos metodos da regra de negocio
        IServiceProduct _IServiceProduct;
        

        //Injeçao de dependencia
        public AppProduct(IProduct IProduct, IServiceProduct IServiceProduct)
        {
            _IProduct = IProduct;
            _IServiceProduct = IServiceProduct;
        }


        #region Metodos novos gerados na regra de negocio do domain Service
        public void AddProduto(Produto p)
        {
            _IServiceProduct.AddProduto(p);

        }
        public void UpdateProduto(Produto p)
        {
            _IServiceProduct.UpdateProduto(p);
        }
        #endregion


        #region Metodos crud do domain generico


        public void Add(Produto obj)
        {
            _IProduct.Add(obj);
        }


        public List<Produto> List()
        {
            return _IProduct.List();
        }

        public Produto SearchForId(int id)
        {
            return _IProduct.SearchForId(id);
        }

        public void Update(Produto obj)
        {
            _IProduct.Update(obj);
        }

        public void Delete(Produto obj)
        {
            _IProduct.Delete(obj);
        }


        #endregion
    }
}
