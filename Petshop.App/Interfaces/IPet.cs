using Petshop.App.Enums;

namespace Petshop.App.Interfaces;


    public interface IPet
    {

        int Id { get; init; }

        string Name { get; }

        Animal Animal { get; init; }

        string Feed { get; init; }


        public string Eat()
        {
            return "";
        }
        
   
        
    }

