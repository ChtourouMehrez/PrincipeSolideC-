using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Segregation_Principle
{
    public interface IRepository :IRepositoryLogique1,IRepositoryLogique2
    {
        //Book? GetById(int id);
        //IEnumerable<Book> GetAll();
        //void Add(Book book);
        //void Update(Book book);
        //void Delete(Book book);
        //Task Save();

    }
}
