namespace DemoBlazorWASM.Pages.Demo5
{
    public class Result
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Pokedex
    {
        public int count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<Result> results { get; set; }
    }
}
