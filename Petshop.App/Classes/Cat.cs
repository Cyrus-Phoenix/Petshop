using Petshop.App.Enums;
using Petshop.App.Interfaces;
using System.Security.Cryptography.X509Certificates;

namespace Petshop.App.Classes
{
    public class Cat : IPet
    {
        public int Id { get; init; }

        public string Name { get; }

        public Animal Animal { get; init; }

        public string Feed { get; init; }


        public Cat(int id, string name, Animal animal, string feed)
        {
            Id = id;
            Name = name;
            Animal = animal;
            Feed = feed;
        }
      
        /*  Shorter way to type the code above   */
        //        public Cat(int id, string name, Animal animal, string feed ) => (Id, Name, Animal, Feed) = (id, name, animal, feed);

        public string Eat()
        {


            string catEat = $"Chewing on a {Feed} ";
            return catEat;
        }




    }
}
