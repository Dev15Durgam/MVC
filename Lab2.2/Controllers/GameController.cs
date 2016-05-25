using Lab_2_2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_2_2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            var game = new GameTModel();
            this.Session["game"] = game;
            return View(game);
        }
        [HttpPost]
        public ActionResult Index(int? userInput)
        {

            var game = (GameTModel)this.Session["game"];

            List<string> IndexList = new List<string>();

            var list = (List<string>)this.Session["List"];
            if (list != null)
            {
                IndexList = (List<string>)list;
            }

            if (IndexList.IndexOf(userInput.ToString()) == -1)
            {

                if (userInput == null || game == null)
                {
                    return Index();
                }
                game.PlayLogic(userInput.Value);
                IndexList.Add(userInput.Value.ToString());
            }
            this.Session["List"] = IndexList;
            return View(game);
        }
    }
}