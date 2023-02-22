using DataLayer.IRepository;
using DataLayer.Models;
using DataLayer.UnitOfWork;
using MediCareLab.Models;
using Microsoft.AspNetCore.Mvc;
using Raven.Abstractions.Smuggler.Data;
using System.Diagnostics;

namespace MediCareLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(ILogger<HomeController> logger, IUnitOfWork unitOfWork)
        {
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task <IActionResult> Index()
        {
            //var ss = await _unitOfWork.UserRepository.GetAllUsersAsync();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AboutUs()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}