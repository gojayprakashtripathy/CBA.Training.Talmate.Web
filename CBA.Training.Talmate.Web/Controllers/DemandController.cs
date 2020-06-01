using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CBA.Training.Talmate.Web.Models;
using CBA.Training.Talmate.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CBA.Training.Talmate.Web.Controllers
{
    public class DemandController : Controller
    {
        private readonly IMapper _mapper;
        public DemandController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Mapping()
        {
            var Demand = GetDemand();
            var DemandViewModel = _mapper.Map<DemandDTO>(Demand);
            return View(DemandViewModel);
        }
        private static Demand GetDemand()
        {
            return new Demand
            {
                DemandId = 1,

                PrimarySkill = "Java",

                SecondarySkill = "spring",

                ExperienceInYears = 5,
                Location = "xyz"
            };
        }
    }
}