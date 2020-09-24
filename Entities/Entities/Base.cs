using Entities.Notifies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Entities
{
    public class Base:Notifiers
    {
        [Display(Name ="Codigo")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
