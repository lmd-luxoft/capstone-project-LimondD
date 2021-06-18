using HomeAccounting.BusinessLogic.Contract;
using HomeAccounting.BusinessLogic.Contract.Dto;
using HomeAccounting.BusinessLogic.EF.Domain;
using HomeAccounting.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace HomeAccounting.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAccountingService _accountingService;

        public HomeController(ILogger<HomeController> logger,
            IAccountingService accountingService)
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

        //// Temporary
        //public IActionResult CreateAccount()
        //{
        //    var account = new Account()
        //    {
        //        Title = "Текст",
        //        CreationDate = DateTime.Now,
        //    };
        //    _accountingService.CreateAccount(account);

        //    return Json(new { Status = true });
        //}

        public IActionResult CreateDeposite()
        {
            var account = new AccountModel
            {
                Type = AccountType.Deposit,
                Amount = 10000,
                Params = new object[] { "12345", 5.3m },
                Title = "Мой депозит"
            };

            _accountingService.CreateAccount(account);
            return Json(new { Status = true });
        }

        public IActionResult CreateProperty()
        {
            var account = new AccountModel
            {
                Type = AccountType.Property,
                Amount = 10000,
                Params = new object[] { PropertyType.UnMoveble },
                Title = "Моё имущество"
            };

            _accountingService.CreateAccount(account);
            return Json(new { Status = true });
        }

        public IActionResult CreateSimple()
        {
            var account = new AccountModel
            {
                Type = AccountType.Simple,
                Amount = 10000,
                Title = "Мой простой аккаунт"
            };

            _accountingService.CreateAccount(account);
            return Json(new { Status = true });
        }

        public IActionResult CreateCash()
        {
            var account = new AccountModel
            {
                Type = AccountType.Cash,
                Amount = 10000,
                Title = "Мой кошелек"
            };

            _accountingService.CreateAccount(account);
            return Json(new { Status = true });
        }

        //public IActionResult GetAccount()
        //{
        //    var account = _accountingService.GetAccountById(1);

        //    return Json(account);
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
