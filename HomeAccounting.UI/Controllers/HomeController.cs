using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace HomeAccounting.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccounting _accountingService;

        public HomeController(ILogger<HomeController> logger,
            IAccounting accountingService)
        {
            _logger = logger;
            _accountingService = accountingService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Temporary
        public IActionResult CreateAccount()
        {
            var account = new Account()
            {
                Title = "Текст",
                CreationDate = DateTime.Now,
            };
            _accountingService.CreateAccount(account);

            return Json(new { Status = true });
        }

        public IActionResult GetAccount()
        {
            var account = _accountingService.GetAccountById(1);

            return Json(account);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
