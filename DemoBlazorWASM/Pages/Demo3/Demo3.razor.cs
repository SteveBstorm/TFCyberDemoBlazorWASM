using Newtonsoft.Json;

namespace DemoBlazorWASM.Pages.Demo3
{
    public partial class Demo3
    {
        public Film MyForm { get; set; } = new Film();

        public void Submit()
        {
            Console.WriteLine(JsonConvert.SerializeObject(MyForm));
        }
    }
}
