using Lab_4_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_4_1.Controllers
{
    public class TwentyOneController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: TwentyOne
        [HttpGet]
        public PartialViewResult TwentyOneGame()
        {
            var game = new _21GameModel();
            return PartialView(game);
        }
        [HttpPost]
        public PartialViewResult TwentyOneGame(_21GameModel game)
        {
            game.UserInputLogic();

            if (game.WinLogic() && game.ComputerWin == false)
            {
                ViewBag.result = "player win";
                game.CurrentNumber = 0; //Reset after a finished game
            }
            game.ResponseLogic();

            if (game.WinLogic() && game.ComputerWin == true)
            {
                ViewBag.result = "Computer Win";
                game.CurrentNumber = 0; //Reset after a finished game
            }

            ModelState.Remove("CurrentNumber");
            return PartialView(game);

        }
    }
}