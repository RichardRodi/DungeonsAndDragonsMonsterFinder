using DungeonsAndDragonsMonsterFinder.Models;

namespace DungeonsAndDragonsMonsterFinder.MonsterRepo
{
    public interface IMonsterRepository
    {
        IEnumerable<Monsters> GetAllMonsters();

        IEnumerable<Monsters> SearchMonstersName(string searchStringName);

        IEnumerable<Monsters> SearchMonstersMeta(string searchStringMeta);

        IEnumerable<Monsters> SearchMonstersArmorClass(string searchStringArmorClass);
    }
}
