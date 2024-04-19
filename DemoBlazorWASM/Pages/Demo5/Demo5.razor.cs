using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace DemoBlazorWASM.Pages.Demo5
{
    public partial class Demo5
    {
        public Pokedex Pokedex { get; set; }

        [Inject]
        public HttpClient client { get; set; }

        protected async override Task OnInitializedAsync()
        {
            client.BaseAddress = new Uri("https://pokeapi.co/api/v2/pokemon");

            Pokedex = await client.GetFromJsonAsync<Pokedex>("");

            //client.PostAsJsonAsync("", Pokedex);

            Console.WriteLine(JsonConvert.SerializeObject(Pokedex));
        }
    }
}
