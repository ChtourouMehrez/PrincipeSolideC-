using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


// on a ajouter cette classe pour séparer chaque responsabilité tout seule 

namespace Single_responsibility_Principle
{
    public class BookRepository
    {

        public async Task SaveToFile(Book book)
        {
            await File.WriteAllTextAsync($"./ook-{book.Title}.json", JsonSerializer.Serialize(book, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            }));
        }
    }
}

//cette classe se charger d'aller gérer la sauvegarde la gestion de la couche d'acces de données 
