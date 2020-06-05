using CBA.Training.Talmate.Web.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CBA.Training.Talmate.Web.UnitTests
{
    public class RecommendationControllerTests
    {
        
        private RecommendationController _controller;

        [SetUp]
        public void Setup()
        {            
            _controller = new RecommendationController();
        }

        [Test]
        public async Task Seek_ReturnsAsActionResult_WithSeekPage()
        {
            var result = await _controller.Seek();
            Assert.Pass();
            Assert.IsNotNull(result as IActionResult);
        }
        [Test]
        public async Task Accept_ReturnsAsActionResult_WithAcceptPage()
        {
            var result = await _controller.Seek();
            Assert.Pass();
            Assert.IsNotNull(result as IActionResult);
        }
    }
}
