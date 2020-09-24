using Entities.Notifies;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Entities
{
    public class Produto : Notifiers
    {
        //A entidade do banco vem aqui com suas colunas
        [Column("PD_ID")]
        [Display(Name = "Codigo")]
        public int Id { get; set; }

        [Column("PD_Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("PD_Valor")]
        [Display(Name = "Valor")]
        public decimal Valor{ get; set; }

        [Column("PD_Estado")]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }
    }
}
