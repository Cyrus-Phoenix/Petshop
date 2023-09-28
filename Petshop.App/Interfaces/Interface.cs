using Petshop.App.Enums;

namespace Petshop.App.Interfaces
{
    public interface IPet
    {
        int Id { get; }

        string Name { get; }

        Animal Animal { get; }

        string Feed { get; init; }


        public string Eat() => Feed;
        

    }
}
