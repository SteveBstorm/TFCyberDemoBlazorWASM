using System.ComponentModel.DataAnnotations;

namespace DemoBlazorWASM.Pages.Exercices.Models
{
    public class ArticleForm
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, 5000)]
        public int Price { get; set; }
        [MinLength(20)]
        public string Description { get; set; }
    }
}
