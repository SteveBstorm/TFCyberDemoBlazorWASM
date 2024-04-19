using DemoBlazorWASM.Pages.Exercices.Models;
using Microsoft.AspNetCore.Components;

namespace DemoBlazorWASM.Pages.Exercices
{
    public partial class AddArticleForm
    {
        public ArticleForm MyForm { get; set; }

        [Parameter]
        public EventCallback<ArticleForm> NotifyCreated { get; set; }

        protected override void OnInitialized()
        {
            MyForm = new ArticleForm();
        }

        public void Submit()
        {
            NotifyCreated.InvokeAsync(MyForm);
            MyForm = new ArticleForm();
        }
    }
}
