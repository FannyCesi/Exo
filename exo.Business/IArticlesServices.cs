using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using exo.Services;
using exo.Common.Models;

namespace exo.Business
{
    public interface IArticlesServices
    {
        public string AddArticle(Article article); 

        public string UpdateArticle(int Id) ; 

        public string DeleteArticle(int id) ; 

        public string Display1Article(int id) ; 
    }
}