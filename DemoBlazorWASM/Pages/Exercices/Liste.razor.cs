using DemoBlazorWASM.Pages.Exercices.Models;

namespace DemoBlazorWASM.Pages.Exercices
{
    public partial class Liste
    {
        public List<Article> ListeArticle { get; set; }

        public void AddArticle(ArticleForm article)
        {
            Article toAdd = new Article
            {
                Id = ListeArticle.Max(x => x.Id) + 1,
                Name = article.Name,
                Price = article.Price,
                Description = article.Description
            };
            ListeArticle.Add(toAdd);
        }

        protected override void OnInitialized()
        {
            ListeArticle = new List<Article>();
            ListeArticle.Add(new Article
            {
                Id = 1,
                Name = "Cuillere",
                Price = 2,
                Description = "J'apprécie les fruits au sirop"
            });
            ListeArticle.Add(new Article
            {
                Id = 2,
                Name = "Graal",
                Price = 2000,
                Description = "Le graal, c'est un bocal à hanchois"
            });
        }

        public void Remove(int id)
        {
            int index = ListeArticle.FindIndex(x => x.Id == id);
            ListeArticle.RemoveAt(index);
        }

        public Article SelectedArticle { get; set; }
        public void SelectArticle(Article a)
        {
            SelectedArticle = a;
        }
    }
}
