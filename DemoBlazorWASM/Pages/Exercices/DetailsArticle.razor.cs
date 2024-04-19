using DemoBlazorWASM.Pages.Exercices.Models;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace DemoBlazorWASM.Pages.Exercices
{
    public partial class DetailsArticle
    {
        [Parameter]
        public Article currentArticle { get; set; }
    }
}
