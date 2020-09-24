using Domain.Interfaces.Generics;
using Infrastructure.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Infrastructure.Repository.Generics
{
    public class RepositoriyGeneric<T> : IGeneric<T>,IDisposable where T : class
    {

        //Como mexemos bastante com banco de dados o disposable da uma limpada no lixo do .net de uma maneira manual

        //Vamos dar vida aos metodos, com o repository nos manipulamos o banco de dados

        private readonly DbContextOptions<ContextBase> _OptionsBuilder;
        //Injeçao de dependencia
        public RepositoriyGeneric()
        {
            _OptionsBuilder = new DbContextOptions<ContextBase>();
        }
        public void Add(T obj)
        {
            using (var contexto = new ContextBase(_OptionsBuilder))
            {
                //Esse set T deixa o metodo generico, como se a gente pegasse a entidade e digitasse contexto.Entidade.Add()
                contexto.Set<T>().Add(obj);
                contexto.SaveChanges();
            }
        }


        public List<T> List()
        {
            using (var contexto = new ContextBase(_OptionsBuilder))
            {
                //AsNoTracking deixa a consulta mais rapida
                return contexto.Set<T>().AsNoTracking().ToList();
            }
        }

        public T SearchForId(int id)
        {
            using (var contexto = new ContextBase(_OptionsBuilder))
            {
                return contexto.Set<T>().Find(id);
            }
        }

        public void Update(T obj)
        {
            using (var contexto = new ContextBase(_OptionsBuilder))
            {
                contexto.Set<T>().Update(obj);
            }
        }

        public void Delete(T obj)
        {
            using (var contexto = new ContextBase(_OptionsBuilder))
            {
                contexto.Set<T>().Remove(obj);
            }
        }



        #region Dispose

        //To detect redundant calls
        private bool _disposed = false;

        // Instantiate a SafeHandle instance.
        private SafeHandle _safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose() => Dispose(true);

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
            {
                return;
            }

            if (disposing)
            {
                // Dispose managed state (managed objects).
                _safeHandle?.Dispose();
            }

            _disposed = true;
        }

       
        #endregion



    }
}
