namespace DemoBlazorWASM.Pages
{
    public partial class Demo1
    {
        public bool IsBool { get; set; } = true;

        public string Value { get; set; }

        public void MaMethode()
        {
            IsBool = !IsBool;
        }
    }
}
