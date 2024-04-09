using DungeonsAndDragonsMonsterFinder.Models;

namespace DungeonsAndDragonsMonsterFinder.MonsterRepo
{
    public interface IMonsterRepository
    {
        IEnumerable<Monsters> GetAllMonsters();

        IEnumerable<Monsters> SearchMonstersName(string searchStringName);

        IEnumerable<Monsters> SearchMonstersMetaSize(string size);

        IEnumerable<Monsters> SearchMonstersLanguages(string language);

        IEnumerable<Monsters> SearchMonstersTraits(string trait);

        Monsters GetMonster(string name);
    }
}
