using Petshop.App.Enums;

namespace Petshop.App.Interfaces;


    public interface IPet
    {

        int Id { get; init; }

        string Name { get; }

        Animal Animal { get; init; }

        string Feed { get; init; }


         string Eat()
        {
            return string.Empty;
        }

    // Samma som ovan?
    // string Eat();
        
    }

