using Interface_Segregation_Principle;
using System;

DisplayAllBooks(new BookRepository());
AddNewBook(new BookRepository());
void DisplayAllBooks(IRepositoryLogique2 repo)
{
    var books = repo.GetAll();
    foreach (var book in books)
    {
        Console.WriteLine(book.Title);
    }
}
void AddNewBook(IRepositoryLogique1 repo)
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