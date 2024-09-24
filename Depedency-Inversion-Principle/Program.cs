using Depedency_Inversion_Principle;
using System;

DisplayAllBooks(new BookRepository());
AddNewBook(new SQLBookRepository());

//lister les livre dans la liste sauvegarder dans la mémoire
void DisplayAllBooks(IRepository repo)
{
    var books = repo.GetAll();
    foreach (var book in books)
    {
        Console.WriteLine(book.Title);
    }
}
//insertion dans la base de donnée SQL
void AddNewBook(IRepository repo)
{

    var book = new Book
    {
        Author = "Mehrez",
        ISBN = 1,
        NbrePage = 5,
        Title = "Les Principes Solide"
    };
    repo.Add(book);
}