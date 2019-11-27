using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApexStatTracker.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApexStatTracker.Controllers
{
    public class JakeController : Controller
    {
        private readonly ApexDbContext _context;
        public JakeController(ApexDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(new Jake());
        }

        [HttpPost]
        public IActionResult Index(Jake j, string calculate, string save)
        {
            if (calculate == "calc")
            {
                j.GameScore = j.Damage + (j.Kills * 75) + (j.Revives * 50) + (j.Respawns * 150) - (j.Revived * 50);

                return View(j);
            }

            else if (save == "save")
            {
                _context.Jake.Add(j);
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
            List<Jake> gameLog = _context.Jake.ToList();
            return View(gameLog);
        }
        public IActionResult Stats(Jake j)
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


            List<Jake> averages = _context.Jake.ToList();
            foreach (var item in averages)
            {
                gameTotal++;
                damageTotal = damageTotal + item.Damage;
                killTotal = killTotal + item.Kills;
                revivesTotal = revivesTotal + item.Revives;
                revivedTotal = revivedTotal = item.Revived;
                respawnsTotal = respawnsTotal + item.Respawns;
                gameScoreTotal = gameScoreTotal + item.GameScore;
                damageAvg = damageTotal / gameTotal;
                killAvg = killTotal / gameTotal;
                revivesAvg = revivesTotal / gameTotal;
                revivedAvg = revivedTotal / gameTotal;
                gameScoreAvg = gameScoreTotal / gameTotal;


                Console.WriteLine(damageTotal);
            }




            return View(j);
        }
    }
}



