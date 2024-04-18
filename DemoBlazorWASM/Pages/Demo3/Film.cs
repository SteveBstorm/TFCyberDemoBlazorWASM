using DataAnnotationsExtensions;
using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations;

namespace DemoBlazorWASM.Pages.Demo3
{
    public class Film
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Le titre est obligatoire pour un film espece d'abruti")]
        [MinLength(1)]
        public string Title { get; set; }
        [Range(1970, 2025)]
        public int ReleaseYear { get; set; }
        [Required]
        public string RealistorFirstname { get; set; }
        [Required]
        public string RealistorLastname { get; set; }
    }

    
}
