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
        // GET: TwentyOne
        [HttpGet]
        public ActionResult TwentyOneGame()
        {
            var game = new _21GameModel();
            return View(game);
        }
        [HttpPost]
        public ActionResult TwentyOneGame(_21GameModel game)
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
            return View(game);

        }
    }
}