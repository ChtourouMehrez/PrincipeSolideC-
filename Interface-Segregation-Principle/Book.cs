using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;


//Chaque classe doit avoir une seule responsabilité 


// ancien code :
//namespace Single_responsibility_Principle
//{
//    public class Book
//    {
//        public string Title { get; set; }
//        public string Author { get; set; }
//        public int NbrePage { get; set; }
//        public int ISBN { get; set; }

//        public async Task SaveToFile()
//        {
//            await File.WriteAllTextAsync($"./ook-{Title}.json", JsonSerializer.Serialize(this, new JsonSerializerOptions
//            {
//                PropertyNameCaseInsensitive = true
//            }));
//        }
//    }
//}



namespace Interface_Segregation_Principle
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int NbrePage { get; set; }
        public int ISBN { get; set; }


        //on a déplacer ce code dans une autre classe séparer
        //public async Task SaveToFile()
        //{
        //    await File.WriteAllTextAsync($"./ook-{Title}.json", JsonSerializer.Serialize(this, new JsonSerializerOptions
        //    {
        //        PropertyNameCaseInsensitive = true
        //    }));
        //}
    }
}
//cette classe se charger de transfer les caractéristique de livre d'une méthode a une autre 