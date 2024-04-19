using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System.Data;

namespace DemoBlazorWASM.Pages.Demo4
{
    public partial class Demo4
    {
        [Inject]
        public ArticleService _service { get; set; }

        [Inject]
        public IJSRuntime JsRuntime { get; set; }

        public void StoreValue()
        {
            JsRuntime.InvokeVoidAsync("localStorage.setItem", "maValeur", _service.MyProperty);
        }

        public async void ReadValue()
        {
            int n = await JsRuntime.InvokeAsync<int>("localStorage.getItem", "maValeur");
        }

    }
}
