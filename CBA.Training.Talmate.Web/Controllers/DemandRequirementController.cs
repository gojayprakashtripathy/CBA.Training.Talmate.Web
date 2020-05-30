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
    public class DemandRequirementController : Controller
    {
        private readonly IMapper _mapper;
        public DemandRequirementController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var Demand = GetDemand();
            var DemandViewModel = _mapper.Map<DemandRequirementViewModel>(Demand);
            return View(DemandViewModel);
        }
            private static DemandRequirement GetDemand()
            {
                return new DemandRequirement
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
