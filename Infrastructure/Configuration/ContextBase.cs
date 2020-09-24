using Entities.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Configuration
{
    //Passo a entidade de usuario(AppUser) criada pelo identity para criar no banco n 
    public class ContextBase : IdentityDbContext<AppUser>
    {

        //Pegamos a entidade Produtos que vamos criar no banco, localizada na entities
        public DbSet<Produto> Produtos { get; set; }

        public ContextBase(DbContextOptions<ContextBase> options):base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(getConnectionString());
                base.OnConfiguring(optionsBuilder);
            } 
        }


        private string getConnectionString()
        {

            return @"Data Source=.\SqlExpress;Initial Catalog=DDDEcommerceEstudo;User ID =sa;Password=sa132;";

        }

        
    }
}
