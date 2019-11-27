using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApexStatTracker.Models;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace ApexStatTracker.Controllers
{
    public class AaronController : Controller
    {
        
        private readonly ApexDbContext _context;
        public AaronController(ApexDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(new Aaron());
        }

        [HttpPost]
        public IActionResult Index(Aaron a, string calculate, string save)
        {
            if (calculate == "calc")
            {
                a.GameScore = a.Damage + (a.Kills * 75) + (a.Revives * 50) + (a.Respawns * 150) - (a.Revived * 50);

                return View(a);
            }

            else if (save == "save")
            {
                _context.Aaron.Add(a);
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
            List<Aaron> gameLog = _context.Aaron.ToList();
            return View(gameLog);
        }
        public IActionResult Stats(Aaron a)
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


            List<Aaron> averages = _context.Aaron.ToList();
            foreach(var item in averages)
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
                

                Console.WriteLine(damageTotal);
            }
           
            

                
            return View(a);
        }
    }
}



