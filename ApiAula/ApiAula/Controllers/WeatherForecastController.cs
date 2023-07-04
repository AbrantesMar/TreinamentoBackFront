using ApiAula.Data;
using ApiAula.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiAula.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private ContextDB contextDB;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
            ContextDB contextDB)
        {
            _logger = logger;
            this.contextDB = contextDB;
        }

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

        [HttpPost(Name = "Test")]
        public string Post()
        {
            string retorno = "";
            Professor p = new Professor
            {
                Cpf = "123",
                Nome = "Marcio",
                Titulacao = "MCP"
            };
            this.contextDB.Professor.Add(p);
            this.contextDB.SaveChanges();
            retorno = "Professor cadastrado com sucesso";
            return retorno;
        }
    }
}