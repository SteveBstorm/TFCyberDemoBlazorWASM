using Microsoft.AspNetCore.Components;

namespace DemoBlazorWASM.Pages.Demo2
{
    public partial class Demo2
    {
        public int valeur { get; set; }

        public bool IsButtonVisible { get; set; }

        [Inject]
        public IConfiguration Config{ get; set; }

        public void ReponseDeEnfant()
        {
            IsButtonVisible = false;
        }
     
        protected override void OnInitialized()
        {
            valeur = 42;
            IsButtonVisible = true;
        }

        public void Increment()
        {
            valeur++;
        }
    }
}
