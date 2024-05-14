using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace exo.Common.Models ; 

    //classe Article
    public class Article{
        public int Id { get; set;}
        public string Title { get; set;}

        public string Content { get; set;}

        public DateTime Date { get; set;}

    //COnstructeur vide d'Articles
    public Article(){
        Title = ""; // Initialisation de title car string
        Content = ""; // idem pour Content
    }         
}

