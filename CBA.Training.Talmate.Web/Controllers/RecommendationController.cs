using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CBA.Training.Talmate.Web.Controllers
{
    public class RecommendationController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Seek()
        {
            return await Task.FromResult(View());
        }

        [HttpGet]
        public async Task<IActionResult> RouteToPM()
        {
            return await Task.FromResult(View());
        }

        [HttpGet]
        public async Task<IActionResult> Accept()
        {
            return await Task.FromResult(View());
        }
    }
}
