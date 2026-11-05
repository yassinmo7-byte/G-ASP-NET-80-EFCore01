using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEF_Core1.Classes
{
    public class BookStoreContext : DbContext
    {

     public DbSet<Book> Books { get; set; }
        

     public DbSet<Author> Authors { get; set; }
        
    public DbSet<Category> Categories { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            optionsBuilder.UseSqlServer("Server = . ; Database= ReadMoreBooksDb; Trusted_Connection = True ;  TrustServerCertificate = True "



                );

        }

    }
}
