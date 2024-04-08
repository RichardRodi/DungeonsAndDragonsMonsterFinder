using DungeonsAndDragonsMonsterFinder.Models;
using DungeonsAndDragonsMonsterFinder.MonsterRepo;
using Microsoft.AspNetCore.Mvc;

namespace DungeonsAndDragonsMonsterFinder.Controllers
{
    public class MonstersController : Controller
    {
        private readonly IMonsterRepository repo;

        public MonstersController(IMonsterRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var monsters = repo.GetAllMonsters();
            return View(monsters);
        }

        public IActionResult Search(string searchStringName)
        {
            var searchResults = repo.SearchMonstersName(searchStringName);
            return View(searchResults);
        }


    }
}
