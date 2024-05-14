using System;
using Microsoft.AspNetCore.Mvc;
using exo.Business;
using exo.Common.Models;
namespace exo.Controllers;

public class HomeController : ControllerBase
{
    public HomeController(){

    } 

    [ApiController] // On définit que c'est un controleur
    [Route("exo.controllers")] // A l'intérieur des guillemets on met l'url qu'on donnera à l'externe pour connexion à l'API    

    [HttpPost]
    public IActionResult AddArticle(Article article){
        var result = 
        return (result);
    } 

    [HttpPost ("update")]
    public IActionResult UpdateArticle(int Id){
        return Ok (result);
    }

    [HttpGet ("{id}")] 
    public IActionResult Display1Article(int id){
        return (result);
    }

    [HttpDelete]
    public IActionResult DeleteArticle(int id){
        return(result);
    }
}

    

