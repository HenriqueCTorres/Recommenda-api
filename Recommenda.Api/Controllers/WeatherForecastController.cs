using Microsoft.AspNetCore.Mvc;
//using Recommenda.Domain.Entities;

namespace Recommenda.Api.Controllers;

//Exemplo feito pela Microsoft
[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries =
    [
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    ];

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }


    public void CreateMovie()
    {
        var nameMovie = "Velozes";

        
        // Movie movie = new Movie( nameMovie, "Muito bom", 2015);
        //
        // //Velozes - 2015 - Muito Bom
        //
        // var text = "Filme: "+ movie.Title + " - " + movie.ReleaseYear + " - " + movie.Description;
        //
        // var textInter = $"Filme {movie.Title} - {movie.ReleaseYear} - {movie.Description}";
        //
        // var textPolimorfimoEscrito = movie.ToString(); //Recommenda.Domain.Entities.Movie



    }
}
