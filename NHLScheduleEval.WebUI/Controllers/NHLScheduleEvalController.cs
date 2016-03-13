using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NHLScheduleEval.Domain.Abstract;
using NHLScheduleEval.Domain.Entities;

namespace NHLScheduleEval.WebUI.Controllers
{
    public class NHLScheduleEvalController : Controller
    {
        private ITeamB2BComparisonRepository repository;

        public NHLScheduleEvalController(ITeamB2BComparisonRepository teamRepository)
        {
            this.repository = teamRepository;
        }

        // GET: NHLScheduleEval
        public ViewResult Index()
        {
            return View(repository.TeamB2BComparisons);
        }
    }
}