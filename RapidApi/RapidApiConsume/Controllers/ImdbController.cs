using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
	public class ImdbController : Controller
	{
		public async Task<IActionResult> Index()
		{
			List<ApiMovieViewModel> apiMovieViewModel = new List<ApiMovieViewModel>
			{
				new ApiMovieViewModel { rank = 1, title = "Movie 1", rating = "8.1" },
				new ApiMovieViewModel { rank = 2, title = "Movie 2", rating = "8.0" },
			};
			var client = new HttpClient();
			var request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri("https://imdb-top-1000-movies-series.p.rapidapi.com/byrating"),
				Headers =
				{
					{ "x-rapidapi-key", "c8d9cb9c3cmsh052b30313558c4ap1674e0jsnb4bf529c45a1" },
					{ "x-rapidapi-host", "imdb-top-1000-movies-series.p.rapidapi.com" },
				},
			};

			using (var response = await client.SendAsync(request))
			{
				if (response.IsSuccessStatusCode)
				{
					var body = await response.Content.ReadAsStringAsync();
					Console.WriteLine(body); // logged the raw response to check it.

					var apiMovieViewModels = JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
				}
				else
				{
					Console.WriteLine($"Error: {response.StatusCode}"); // Log the error.
				}
				return View(apiMovieViewModel);
			}
		}
	}
}
