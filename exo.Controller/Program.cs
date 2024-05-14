using Microsoft.AspNetCore.Mvc;
using exo.Business;
using exo.Common.Models;


namespace exo.Controllers;

[ApiController] // On définit que c'est un controleur
[Route("exo.controllers")] // A l'intérieur des guillemets on met l'url qu'on donnera à l'externe pour connexion à l'API    

public class HomeController : ControllerBase 
{
    public HomeController(){
    } 

    private readonly IArticlesServices _articleServices ; 

    //Initialisation de la dépendance 
    public HomeController(IArticlesServices articlesServices)
    {
        _articleServices = articlesServices;
    }


    // Appel des fonctions de CRUD de exo.Services
    [HttpPost]
    public IActionResult AddArticle(Article article)
    {
        var result = _articleServices.AddArticle(article);
        return Ok(result); 
    } 

    [HttpPost("update")]
    public IActionResult UpdateArticle(int Id)
    {
        var result = _articleServices.UpdateArticle(Id); 
        return Ok(result);
    }

    [HttpGet("{id}")] 
    public IActionResult Display1Article(int id)
    {
        var result = _articleServices.Display1Article(id); 
        return Ok(result);
    }

    [HttpDelete]
    public IActionResult DeleteArticle(int id)
    {
        var result = _articleServices.DeleteArticle(id); 
        return Ok(result);
    }

}

    

