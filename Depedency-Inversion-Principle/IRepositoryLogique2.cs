using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depedency_Inversion_Principle
{
    public interface IRepositoryLogique2
    {
        Book? GetById(int id);
        IEnumerable<Book> GetAll();
       

    }
}
