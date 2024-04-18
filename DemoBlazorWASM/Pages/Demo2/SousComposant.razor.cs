using Microsoft.AspNetCore.Components;

namespace DemoBlazorWASM.Pages.Demo2
{
    public partial class SousComposant
    {
        [Parameter]
        public int ValueFromCaller { get; set; }
        [Parameter]
        public EventCallback NotifyTaskDone { get; set; }

        protected override void OnParametersSet()
        {
            //if (ValueFromCaller == 98)
            //{
            //    NotifyTaskDone.InvokeAsync();
            //}
            //else
                ValueFromCaller *= 2;
            
        }

        public void RemoveButton()
        {
            NotifyTaskDone.InvokeAsync();
        }

        protected override void OnAfterRender(bool firstRender)
        {
            if (firstRender)
            {
                Console.WriteLine("Bonjour et bienviendu");
            }
            else
            Console.WriteLine("c'est encore toi ?");
        }

        protected override bool ShouldRender()
        {
            return ValueFromCaller % 10 == 0;
        }
    }
}
