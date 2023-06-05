using System.Net.Http.Headers;
using InstagramFollowerrRapidApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace InstagramFollowerrRapidApi.Controllers
{
    public class HomeController : Controller
    {

        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram-profile1.p.rapidapi.com/getprofileinfo/ganioztrk"),
                Headers =
                {
                    { "X-RapidAPI-Key", "57a05ced9fmsh7440ac7d8e5603fp1f46d8jsnd9e3022ec3f3" },
                    { "X-RapidAPI-Host", "instagram-profile1.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();

                InstagramApiViewModel model = JsonConvert.DeserializeObject<InstagramApiViewModel>(body);
                return View(model);
            }
        }

    }
}