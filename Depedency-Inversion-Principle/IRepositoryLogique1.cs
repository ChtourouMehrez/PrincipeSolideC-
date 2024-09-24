using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depedency_Inversion_Principle
{
    public interface IRepositoryLogique1
    {
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
        Task Save();

    }
}
