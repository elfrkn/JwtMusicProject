using JwtMusic.Application.Interfaces;
using JwtMusic.Domain.Entities;
using JwtMusic.WebUI.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Packaging.Core;
using System.Net.Http.Headers;

namespace JwtMusic.WebUI.Controllers
{


    public class MusicController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        

        public MusicController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
          
        }


        public async Task<IActionResult> MusicListByUser()
        {
            var token = User.Claims.FirstOrDefault(x => x.Type == "musictoken")?.Value;

            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var responseMessage = await client.GetAsync("https://localhost:7083/api/Musics/MusicListByRoleId");

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMusicListByRoleId>>(jsonData);
                return View(values);
            }
            return View();
        }


        public async Task<IActionResult> MusicList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7083/api/Musics");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMusicListDto>>(jsonData);
                return View(values);

            }
            return View();

        }

        public async Task<IActionResult> MusicRoleIdQuery(int id)
        {
            ViewBag.RoleId = id;
            var token = User.Claims.FirstOrDefault(x => x.Type == "musictoken")?.Value;

            if (token != null)
            {
                var client = _httpClientFactory.CreateClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                var responseMessage = await client.GetAsync("https://localhost:7083/api/Musics/MusicListByRoleId");

                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMusicListByRoleId>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
