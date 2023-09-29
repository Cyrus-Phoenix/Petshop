using Petshop.App.Interfaces;
using System.Net.Http.Json;
using static Petshop.App.Pages.FetchData;
using static System.Net.WebRequestMethods;

namespace Petshop.App.Classes
{
    public class PetStore
    {
        //Vad exakt gör koden nedan?
        HttpClient _http;

        public PetStore(HttpClient http) => _http = http;

        //lista med propertina av IPets och till delas till variabeln Pets och vi omvandlar hela till en object med = new(); ?
        public List<IPet> Pets { get; private set; } = new();
        public string Message { get; private set; } = string.Empty;


        //async kommer alltid med Task och vad händer här exakt?
        public async Task<List<IPet>> LoadPets() 
        { 
            //Vad gör keyworden await?
            var cats = await _http.GetFromJsonAsync<List<Cat>>("sample-data/cats.json");
            var dogs = await _http.GetFromJsonAsync<List<Dog>>("sample-data/dogs.json");
            
            // vad gör keyworden AddRange?
            if (cats is not null) Pets.AddRange(cats);
            if (dogs is not null) Pets.AddRange(dogs);

            return Pets;
        }

       

    }
}
