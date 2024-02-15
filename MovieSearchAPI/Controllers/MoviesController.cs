using Microsoft.AspNetCore.Mvc;
using MovieSearchAPI.Data;


namespace MovieSearchAPI.Controllers
{
    [ApiController]
    [Route("/api/movies")]
    public class MoviesController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MoviesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        // GET: /api/movies/?s=query
        [HttpGet()]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies(string s)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var uri = $"http://www.omdbapi.com/?apikey=d05aeeac&s={s}";
                //var uri = $"http://www.omdbapi.com/?apikey={process.env.NEXT_PUBLIC_API_KEY}&${searchQuery}";

                var response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    // Process the responseData as needed
                    return Ok(responseData);
                }
                else
                {
                    // Handle the error response
                    return StatusCode((int)response.StatusCode, response.ReasonPhrase);
                }

            }
            catch (Exception ex)
            {
                // Handle the exception
                return BadRequest($"Error: {ex.Message}");
            }
        }

        // GET: /api/movies/:id
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovieById(string id)
        {
            try
            {
                var httpClient = _httpClientFactory.CreateClient();
                var uri = $"http://www.omdbapi.com/?apikey=d05aeeac&i={id}";
                //var uri = $"http://www.omdbapi.com/?apikey={process.env.NEXT_PUBLIC_API_KEY}&${searchQuery}";

                var response = await httpClient.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var responseData = await response.Content.ReadAsStringAsync();
                    // Process the responseData as needed
                    return Ok(responseData);
                }
                else
                {
                    // Handle the error response
                    return StatusCode((int)response.StatusCode, response.ReasonPhrase);
                }

            }
            catch (Exception ex)
            {
                // Handle the exception
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}

