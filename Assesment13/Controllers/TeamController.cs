using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment13.Controllers
{
    public class TeamController : Controller
    {
        // GET: Team

        List<Team> listTeam = new List<Team>()
        {
            new Team(){Id=1,Name="India",NOWC= 2},
            new Team(){Id=2,Name="Australia",NOWC=4},
            new Team(){Id=3,Name="west Indies",NOWC=4},
            new Team(){Id=4,Name="England",NOWC= 1},

        };
        public ActionResult Index()
        {
            return View(listTeam);
        }

    }
}