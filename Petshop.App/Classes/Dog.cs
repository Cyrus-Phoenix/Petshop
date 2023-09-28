using Petshop.App.Enums;

namespace Petshop.App.Classes
{
    public class Dog
    {
        public int Id { get; init; }

        public string Name { get; }

        public Animal Animal { get; init; }

        public string Feed { get; init; }

        public string Eat()
        {
            return $"Munching on {Feed} ";
        }

        public Dog(int id, string name, Animal animal, string feed) => (Id, Name, Animal, Feed) = (id, name, animal, feed);



    }

}
