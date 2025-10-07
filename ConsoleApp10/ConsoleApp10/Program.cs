using ConsoleApp10.Library;
using ConsoleApp10.Models;
Library library = new(3);

library.AddBook(new Book("Book1", 10, "A1", 100));
library.AddBook(new Book("Book1", 10, "A1", 100));

Console.WriteLine(library.GetBookById(1)); 