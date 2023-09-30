using Petshop.App.Interfaces;
using System.Net.Http.Json;
using static Petshop.App.Pages.FetchData;
using static System.Net.WebRequestMethods;

namespace Petshop.App.Classes
{
    public class PetStore
    {
        // Vad exakt gör koden nedan?
        // Är detta kortsagt gjort för att kunna hämta/läsa data från json filerna via Async metoden? 



        /* 
         *  Min tolking av koden
         *  
         *  HttpClient _http;                                   <-- säger att variabel typen ska vara HttpClient ( vilket är biblioteket för att kunna exempelvis läsa från json fil ) 
         *                                                          med variabel namn _http. Kortsagt vi ska spara i _http något som ska läsas av http tjänst.
         *  
         *  
         *  
         *  public PetStore(HttpClient http) => _http = http;   <-- Vi skapar en konstruktor som säger i parametern att vi ska ta in typen HttpClient med variabeln namn http. 
         *                                                          fatarrow säger ta http datan och lägg in det i _http variabeln
         *   
         *   
         *   
         *  public List<IPet> Pets { get; private set; } = new(); <-- vi använder interfacet IPet regler för att kunna hämta datan och lägga in det i en lista 
         *                                                            och med new(); så skapar vi en tom list objekt.
         *  
         *  
         *  
         *   public async Task<List<IPet>> LoadPets()             <-- ( https tjänst ) Här använder oss av async metod för att den ska laddas samtidigt som resten av hemsidan via egen tråd 
             {                                                        och vi säger datan som vi får in ska använda interfacets regler. <- detta kan vara väldigt fel.
            
                    var cats = await _http.GetFromJsonAsync<List<Cat>>("sample-data/cats.json");    <-- Vänta tills du får svar innan du hämtar data
                                                                                                        vi säger sedan att den ska hämta data från sample-data/cats.json 
                                                                                                        med cat listans regler/prop.
                                                                                                        Sedan tilldelar vi en "var cats" pekare till objektet.

                    var dogs = await _http.GetFromJsonAsync<List<Dog>>("sample-data/dogs.json");
            
                  // vad gör keyworden AddRange?
                     if (cats is not null) Pets.AddRange(cats);                                     <-- Om cats objektens datan är inte null så ta all den data som finns och lägg in det i List<IPet> objektet.
                     if (dogs is not null) Pets.AddRange(dogs);

                     return Pets;                                                                   <-- returnera den fyllda List<IPet> listan
           }
         *  
         */
        HttpClient _http;

        public PetStore(HttpClient http) => _http = http;

        // lista med propertina av IPets och det tilldelas till variabeln Pets och vi omvandlar hela till en object med = new(); ?
        public List<IPet> Pets { get; private set; } = new();
        public string Message { get; private set; } = string.Empty;


        // async kommer alltid med Task och vad händer här exakt?
        public async Task<List<IPet>> LoadPets() 
        { 
            // Vad gör keyworden await?
            var cats = await _http.GetFromJsonAsync<List<Cat>>("sample-data/cats.json");
            var dogs = await _http.GetFromJsonAsync<List<Dog>>("sample-data/dogs.json");
            
            // vad gör keyworden AddRange?
            if (cats is not null) Pets.AddRange(cats);
            if (dogs is not null) Pets.AddRange(dogs);

            return Pets;
        }

       

    }
}
