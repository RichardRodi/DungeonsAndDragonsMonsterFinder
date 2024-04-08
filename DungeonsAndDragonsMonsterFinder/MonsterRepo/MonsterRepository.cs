using Dapper;
using DungeonsAndDragonsMonsterFinder.Models;
using System.Data;
using static DungeonsAndDragonsMonsterFinder.MonsterRepo.MonsterRepository;

namespace DungeonsAndDragonsMonsterFinder.MonsterRepo
{
    public class MonsterRepository : IMonsterRepository
    {
        
            private readonly IDbConnection _conn;

            public MonsterRepository(IDbConnection conn)
            {
                _conn = conn;
            }

            public IEnumerable<Monsters> GetAllMonsters()
            {
                return _conn.Query<Monsters>("SELECT * FROM Monsters;");
            }

        public IEnumerable<Monsters> SearchMonstersArmorClass(string searchString)
        {

            return _conn.Query<Monsters>("WHERE NAME LIKE @ArmorClass ORDER BY ArmorClass ASC;", new { ArmorClass = "%" + searchString + "%" });
        }

        public IEnumerable<Monsters> SearchMonstersMeta(string searchString)
        {
            return _conn.Query<Monsters>("SELECT * FROM Monsters WHERE NAME LIKE @meta;", new { meta = "%" + searchString + "%" });
        }

        public IEnumerable<Monsters> SearchMonstersName(string searchString)
        {
            return _conn.Query<Monsters>("SELECT * FROM Monsters WHERE NAME LIKE @name;", new { name = "%" + searchString + "%" });
        }



       
    }
}
