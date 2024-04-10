using Dapper;
using DungeonsAndDragonsMonsterFinder.Models;
using System.Data;

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

        public IEnumerable<Monsters> SearchMonstersLanguages(string language)
        {
            string query = "SELECT * FROM Monsters WHERE Languages LIKE CONCAT('%', @language, '%')";
            switch (language)
            {
                case "--":
                    return _conn.Query<Monsters>(query, new { language = "--" });
                case "Abyssal":
                    return _conn.Query<Monsters>(query, new { language = "Abyssal" });
                case "Aquan":
                    return _conn.Query<Monsters>(query, new { language = "Aquan" });
                case "Auran":
                    return _conn.Query<Monsters>(query, new { language = "Auran" });
                case "Blink Dog":
                    return _conn.Query<Monsters>(query, new { language = "Blink Dog" });
                case "Celestial":
                    return _conn.Query<Monsters>(query, new { language = "Celestial" });
                case "Common":
                    return _conn.Query<Monsters>(query, new { language = "Common" });
                case "creator":
                    return _conn.Query<Monsters>(query, new { language = "creator" });
                case "Deep Speech":
                    return _conn.Query<Monsters>(query, new { language = "Deep Speech " });
                case "Draconic":
                    return _conn.Query<Monsters>(query, new { language = "Draconic" });
                case "Elvish":
                    return _conn.Query<Monsters>(query, new { language = "Elvish" });
                case "Giant":
                    return _conn.Query<Monsters>(query, new { language = "Giant" });
                case "Ignan":
                    return _conn.Query<Monsters>(query, new { language = "Ignan" });
                case "Infernal":
                    return _conn.Query<Monsters>(query, new { language = "Infernal" });
                case "Sphinx":
                    return _conn.Query<Monsters>(query, new { language = "Sphinx" });
                case "Telepathy":
                    return _conn.Query<Monsters>(query, new { language = "Telepathy" });
                case "Thieves":
                    return _conn.Query<Monsters>(query, new { language = "Thieves" });
                case "Undercommon":
                    return _conn.Query<Monsters>(query, new { language = "Undercommon" });
                default:
                    return Enumerable.Empty<Monsters>();
            }

        }


        public IEnumerable<Monsters> SearchMonstersMetaSize(string size)
        {
            string query = "SELECT * FROM Monsters WHERE SUBSTRING_INDEX(meta, ' ', 1) = @size;";

            switch (size)
            {
                case "Tiny":
                    return _conn.Query<Monsters>(query, new { size = "Tiny" });
                case "Small":
                    return _conn.Query<Monsters>(query, new { size = "Small" });
                case "Medium":
                    return _conn.Query<Monsters>(query, new { size = "Medium" });
                case "Large":
                    return _conn.Query<Monsters>(query, new { size = "Large" });
                case "Huge":
                    return _conn.Query<Monsters>(query, new { size = "Huge" });
                case "Gargantuan":
                    return _conn.Query<Monsters>(query, new { size = "Gargantuan" });
                default:

                    return Enumerable.Empty<Monsters>();
            }
        }


        public IEnumerable<Monsters> SearchMonstersName(string searchString)
        {
            return _conn.Query<Monsters>("SELECT * FROM Monsters WHERE NAME LIKE @name;", new { name = "%" + searchString + "%" });
        }

        public IEnumerable<Monsters> SearchMonstersTraits(string trait)
        {
            return _conn.Query<Monsters>("SELECT * FROM Monsters WHERE TRAITS LIKE @Traits;", new { Traits = "%" + trait + "%" });
        }


        public Monsters GetMonster(string monsterId)
        {
            return _conn.QuerySingle<Monsters>("SELECT * FROM Monsters WHERE MonsterId = @MonsterId", new { MonsterId = monsterId });
        }
    }
}
