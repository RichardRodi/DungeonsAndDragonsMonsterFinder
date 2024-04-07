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
        
    }
}
