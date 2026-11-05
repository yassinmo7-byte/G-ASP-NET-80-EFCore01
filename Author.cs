using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppEF_Core1.Classes
{
    public class Author
    {

     public int Id { get; set; }
     public string FirstName { get; set; }
     public string LastName { get; set; }
     public string Email { get; set; }
     public string Biography { get; set; }
     public DateTime DateOfBirth { get; set; }

     public List<Book> Books { get; set; } = new List<Book>();



    }
}
