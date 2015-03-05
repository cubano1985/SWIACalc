using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using Services;

namespace SWIACalc.Controllers
{
    public class DiceCalcController : Controller
    {        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RollResult(int redDice, int blueDice, int yellowDice, int greenDice)
        {
            return null;
        }
    }
}