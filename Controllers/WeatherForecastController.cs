using Microsoft.AspNetCore.Mvc;
using PARCIAL1A.Controllers.models;

namespace PARCIAL1A.Controllers
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
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
    }

    [ApiController]
    [Route("api/[controller]")]
    public class AutoresController : ControllerBase
    {
        
    }

    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {

        [HttpGet("Ultimos20PorAutor")]
        public ActionResult<IEnumerable<Post>> ObtenerAutor(string nombreAutor)
        {

        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class LibrosController : ControllerBase
    {
        // Implementa los métodos CRUD para la entidad Libro
        [HttpGet("BuscarPorAutor")]
        public ActionResult<IEnumerable<Libro>> BuscarAutor(string nombreAutor)
        {
        }

        [HttpGet("PostsPorLibro")]
        public ActionResult<IEnumerable<Post>> ObtenerLibro(int libroId)
        {
        }
    }

    [ApiController]
    [Route("api/[controller]")]
    public class AutoresLibroController : ControllerBase
    {
    }



}