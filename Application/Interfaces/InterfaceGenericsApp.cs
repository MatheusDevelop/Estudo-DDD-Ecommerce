using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface InterfaceGenericsApp<T> where T:class
    {
        //Metodos que ficarão disponibilizados no controller
        void Add(T obj);
        void Update(T obj);

        void Delete(T obj);
        T SearchForId(int id);
        List<T> List();

    }
}
