using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEF_Core1.Classes
{
  

        public class Book
        {
         public int Id { get; set; }                  // Primary Key 
         public string Title { get; set; }
         public string ISBN { get; set; }
         public decimal Price { get; set; }
         public int NumberOfPages { get; set; }
         public int PublishedYear { get; set; }
         public bool IsInStock { get; set; }

            // the Foreign keys 
         public int AuthorId { get; set; }
         public Author Author { get; set; }

         public int CategoryId { get; set; }
         public Category Category { get; set; }
        }
    

}

