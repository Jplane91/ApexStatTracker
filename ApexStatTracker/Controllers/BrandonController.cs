using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApexStatTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApexStatTracker.Controllers
{
    public class BrandonController : Controller
    {
        private readonly ApexDbContext _context;
        public BrandonController(ApexDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(new Brandon());
        }

        [HttpPost]
        public IActionResult Index(Brandon b, string calculate, string save)
        {
            if (calculate == "calc")
            {
                b.GameScore = b.Damage + (b.Kills * 75) + (b.Revives * 50) + (b.Respawns * 150) - (b.Revived * 50);

                return View(b);
            }

            else if (save == "save")
            {
                _context.Brandon.Add(b);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult GameLog()
        {
            List<Brandon> gameLog = _context.Brandon.ToList();
            return View(gameLog);
        }
        public IActionResult Stats(Brandon b)
        {
            int gameTotal = 0;
            double damageTotal = 0;
            double killTotal = 0;
            double revivesTotal = 0;
            double revivedTotal = 0;
            double respawnsTotal = 0;
            double gameScoreTotal = 0;
            double damageAvg = 0;
            double killAvg = 0;
            double revivesAvg = 0;
            double respawnsAvg = 0;
            double revivedAvg = 0;
            double gameScoreAvg = 0;


            List<Brandon> averages = _context.Brandon.ToList();
            foreach (var item in averages)
            {
                gameTotal++;
                damageTotal = damageTotal + item.Damage;
                killTotal = killTotal + item.Kills;
                revivesTotal = revivesTotal + item.Revives;
                revivedTotal = revivedTotal + item.Revived;
                respawnsTotal = respawnsTotal + item.Respawns;
                gameScoreTotal = gameScoreTotal + item.GameScore;
                damageAvg = damageTotal / gameTotal;
                killAvg = killTotal / gameTotal;
                revivesAvg = revivesTotal / gameTotal;
                revivedAvg = revivedTotal / gameTotal;
                gameScoreAvg = gameScoreTotal / gameTotal;

                ViewData["DamageAverage"] = damageAvg;
                ViewData["KillAverage"] = "5";
                ViewData["RevivesAverage"] = revivesAvg;
                ViewData["RevivedAverage"] = revivedAvg;
                ViewData["GameScoreAverage"] = gameScoreAvg;
                
            }




            return View(b);
        }
    }
}



