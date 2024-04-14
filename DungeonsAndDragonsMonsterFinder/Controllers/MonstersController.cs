﻿using DungeonsAndDragonsMonsterFinder.Models;
using DungeonsAndDragonsMonsterFinder.MonsterRepo;
using Microsoft.AspNetCore.Mvc;

namespace DungeonsAndDragonsMonsterFinder.Controllers
{
    public class MonstersController : Controller
    {
        private readonly IMonsterRepository repo;

        // Have all your data //
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

        public IActionResult IndividualView(string monsterId)
        {
            var monster = repo.GetMonster(monsterId);
            return View(monster);
        }

        public IActionResult SearchMonstersActions(string action)
        {
            var searchResults = repo.SearchMonstersActions(action);
            return View(searchResults);
        }
    }
}
