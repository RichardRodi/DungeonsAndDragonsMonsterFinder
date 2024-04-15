﻿using DungeonsAndDragonsMonsterFinder.Models;

namespace DungeonsAndDragonsMonsterFinder.MonsterRepo
{
    public interface IMonsterRepository
    {
        IEnumerable<Monsters> GetAllMonsters();

        IEnumerable<Monsters> SearchMonstersName(string searchStringName);

        IEnumerable<Monsters> SearchMonstersMetaSize(string size);

        IEnumerable<Monsters> SearchMonstersLanguages(string language);

        IEnumerable<Monsters> SearchMonstersTraits(string trait);

        IEnumerable<Monsters> SearchMonstersActions(string action);

        IEnumerable<Monsters> SearchMonstersMeta(string meta);

        IEnumerable<Monsters> SearchMonstersChallenge(string challenge);
        Monsters GetMonster(string name);
    }
}
