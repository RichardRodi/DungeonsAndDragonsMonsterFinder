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
            var monster = repo.GetAllMonsters().ToList();
            return View(monster);
        }

        public IActionResult Search(string searchStringName)
        {
            var searchResults = repo.SearchMonstersName(searchStringName);
            return View(searchResults);
        }


        public IActionResult SearchMonstersMetaSize(string size)
        {
            var searchResults = repo.SearchMonstersMetaSize(size);
            return View(searchResults);
        }

        public IActionResult SearchMonstersLanguages(string language)
        {
            var searchResults = repo.SearchMonstersLanguages(language);
            return View(searchResults);
        }

        public IActionResult SearchMonstersTraits(string trait)
        {
            var searchResults = repo.SearchMonstersTraits(trait);
            return View(searchResults);
        }

        public IActionResult IndividualView(int monsterId)
        {
            var monster = repo.GetMonster(monsterId);
            return View(monster);
        }

        public IActionResult SearchMonstersActions(string action)
        {
            var searchResults = repo.SearchMonstersActions(action);
            return View(searchResults);
        }

        public IActionResult SearchMonstersMeta(string meta)
        {
            var searchResults = repo.SearchMonstersMeta(meta);
            return View(searchResults);
        }
        public IActionResult SearchMonstersChallenge(string challenge)
        {
            var searchResults = repo.SearchMonstersChallenge(challenge);
            return View(searchResults);
        }
        public IActionResult RandomMonster()
        {
            var monsters = repo.GetAllMonsters().ToList();
            var random = new Random();
            var randomMonster = monsters[random.Next(monsters.Count)];

            return View(randomMonster);
        }
        public IActionResult GetMonster(int id)
        {
            var monster = repo.GetMonster(id);
            return View(monster);
        }
        public IActionResult UpdateMonster(int id)
        {
            Monsters monster = repo.GetMonster(id);
            if (monster == null)
            {
                return View("ProductNotFound");
            }
            return View(monster);
        }
        public IActionResult UpdateMonsterToDatabase(Monsters monster)
        {
            repo.UpdateMonster(monster);

            return RedirectToAction("GetMonster", new { id = monster.MonsterId });
        }


        public IActionResult InsertMonster()
        {

            return View();
        }
        public IActionResult InsertMonsterToDatabase(Monsters monster)
        {
            repo.InsertMonster(monster);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteMonster(Monsters monster)
        {
            repo.DeleteMonster(monster);
            return RedirectToAction("Index");
        }
    }
}
