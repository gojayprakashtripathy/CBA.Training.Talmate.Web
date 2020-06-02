using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using CBA.Training.Talmate.Web.Comman;
using CBA.Training.Talmate.Web.Models;
using CBA.Training.Talmate.Web.ModelsDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace CBA.Training.Talmate.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: LoginController
        private AppSettings _settings;
        public LoginController(IOptions<AppSettings> settings)
        {
            _settings = settings.Value;
        }
        [HttpGet]       
        public ActionResult Index()
        {

            return View();
        }
       
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(User user)
        {
            var loginResultData = new UserRolesDTO();
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    string baseUri = _settings.ApiUrl + "/" + Constants.Token + "/";
                    client.BaseAddress = new Uri(baseUri);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    var response = await client.PostAsJsonAsync(baseUri, user);
                    var result = response.Content.ReadAsStringAsync().Result;
                    loginResultData = JsonConvert.DeserializeObject<UserRolesDTO>(result);

                }
            }
            if (loginResultData != null && loginResultData.Token != null)
            {
                HttpContext.Session.SetString("JWTToken", loginResultData.Token);
                Console.WriteLine(HttpContext.Session.GetString("JWTToken"));
                return RedirectToAction("Index", "Dashboard");                
            }                
            else
            {
                ViewBag.message = "Invalid username and password!";
                return View();
            }
        }       

    }
}
