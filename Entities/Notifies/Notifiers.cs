using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Notifies
{
    public class Notifiers
    {
        [NotMapped]
        public string NomeProp { get; set; }
        [NotMapped]
        public string Mensagem { get; set; }
        [NotMapped]
        public List<Notifiers> Notifications { get; set; }
        public Notifiers()
        {
            Notifications = new List<Notifiers>();
        }


        //Algumas regras de negocio para serem implementadas nas outras clases
        public bool ValidarString(string valor,string nome)
        {
            if (string.IsNullOrEmpty(valor)||string.IsNullOrEmpty(nome))
            {
                Notifications.Add(new Notifiers
                {
                    Mensagem="Campo obrigatorio",
                    NomeProp=nome
                });
                return false;
            }
            return true;
        }
        public bool ValidarInt(int valor, string nome)
        {
            if (valor<1|| string.IsNullOrEmpty(nome))
            {
                Notifications.Add(new Notifiers
                {
                    Mensagem = "Campo obrigatorio",
                    NomeProp = nome
                });
                return false;
            }
            return true;
        }

        public bool ValidarDecimal(decimal valor, string nome)
        {
            if (valor < 1 || string.IsNullOrEmpty(nome))
            {
                Notifications.Add(new Notifiers
                {
                    Mensagem = "Campo obrigatorio",
                    NomeProp = nome
                });
                return false;
            }
            return true;
        }


    }
}
