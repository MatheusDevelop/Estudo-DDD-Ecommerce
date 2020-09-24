using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.Generics
{
    public interface IGeneric<T> where T:class
    {
        void Add(T obj);
        void Update(T obj);
        void Delete(T obj);
        T SearchForId(int id);
        List<T> List();



    }
}
