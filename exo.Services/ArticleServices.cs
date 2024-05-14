using System.Collections.Generic;
using exo.Common.Models;

namespace exo.Services;

    public class ArticleServices
    {   
        // Point d'entrée de l'appli
        public static void Main(string[] args){}

        // Liste des articles en référence à Article présent dans exo.Common.Models
        public List<Article> Articles { get; set; }

        // Constructeur pour initialiser la liste d'articles
        public ArticleServices()
        {
            Articles = new List<Article>();
        }

        // CRUD Functions
        

        /// <summary>
        /// Function to add a new article
        /// </summary>
        /// <param name="article"></param>
        public void AddArticle(Article article){
            Articles.Add(article);
        }   

        /// <summary>
        /// Function to get all articles
        /// </summary>
        /// <returns>List of all articles</returns>
        public List<Article> GetAllArticles()
        {
            return Articles;
        }

        /// <summary>
        /// Function that allows to display an article by his Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public string Display1Article(int Id){
        var myArticle = Articles.Find(x => x.Id == Id);
        if (myArticle != null)
        {
            return myArticle.Title;
        }
        return "Article doesn't exisnkt";
        }

        /// <summary>
        /// Fucntion that allows to update an article. 
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public string Update(int Id){
        var myArticle = Articles.Find(x => x.Id == Id);
        if (myArticle != null)
        {
            myArticle.Title = myArticle.Title;
            return "Title has been update to " + myArticle.Title;
        };

        return "Article doesn't exist";
        }

        public string Delete(int id)
        {
        var myArticle = Articles.Find(x => x.Id == id);
        if (myArticle != null)
        {
            Articles.Remove(myArticle);
            return "Article has been deleted";
        }
        return "Article doesn't exist already";

        }

    }
