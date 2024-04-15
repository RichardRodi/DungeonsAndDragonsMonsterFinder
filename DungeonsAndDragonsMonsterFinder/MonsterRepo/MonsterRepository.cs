using Dapper;
using DungeonsAndDragonsMonsterFinder.Models;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Security.Policy;

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


        public IEnumerable<Monsters> SearchMonstersActions(string action)
        {
            string query = "SELECT * FROM Monsters WHERE Actions LIKE CONCAT('%', @action, '%')";
            switch (action)
            {
                case "Beak":
                    return _conn.Query<Monsters>(query, new { action = "Beak" });
                case "Bite":
                    return _conn.Query<Monsters>(query, new { action = "Bite" });
                case "Claw":
                    return _conn.Query<Monsters>(query, new { action = "Claw" });
                case "Club":
                    return _conn.Query<Monsters>(query, new { action = "Club" });
                case "Corrupting Touch":
                    return _conn.Query<Monsters>(query, new { action = "Corrupting Touch" });
                case "Crush":
                    return _conn.Query<Monsters>(query, new { action = "Crush" });
                case "Dagger":
                    return _conn.Query<Monsters>(query, new { action = "Dagger" });
                case "Enlarge":
                    return _conn.Query<Monsters>(query, new { action = "Enlarge" });
                case "Fist":
                    return _conn.Query<Monsters>(query, new { action = "Fist" });
                case "Gore":
                    return _conn.Query<Monsters>(query, new { action = "Gore" });
                case "Greataxe":
                    return _conn.Query<Monsters>(query, new { action = "Greataxe" });
                case "Greatclub":
                    return _conn.Query<Monsters>(query, new { action = "Greatclub" });
                case "Life Drain":
                    return _conn.Query<Monsters>(query, new { action = "Life Drain" });
                case "Longsword":
                    return _conn.Query<Monsters>(query, new { action = "Longsword" });
                case "Mace":
                    return _conn.Query<Monsters>(query, new { action = "Mace" });
                case "MorningStar":
                    return _conn.Query<Monsters>(query, new { action = "MorningStar" });
                case "Multi Attack":
                    return _conn.Query<Monsters>(query, new { action = "Multiattack" });
                case "Paralyzing Touch":
                    return _conn.Query<Monsters>(query, new { action = "Paralyzing Touch" });
                case "Psuedopod":
                    return _conn.Query<Monsters>(query, new { action = "Psuedopod" });
                case "Quaterstaff":
                    return _conn.Query<Monsters>(query, new { action = "Quaterstaff" });
                case "Rake":
                    return _conn.Query<Monsters>(query, new { action = "Rake" });
                case "Ram":
                    return _conn.Query<Monsters>(query, new { action = "Ram" });
                case "Scimitar":
                    return _conn.Query<Monsters>(query, new { action = "Scimitar" });
                case "Shortsword":
                    return _conn.Query<Monsters>(query, new { action = "Shortsword" });
                case "Slam":
                    return _conn.Query<Monsters>(query, new { action = "Slam" });
                case "Spear":
                    return _conn.Query<Monsters>(query, new { action = "Spear" });
                case "Spiked Bone Club":
                    return _conn.Query<Monsters>(query, new { action = "Spiked Bone Club" });
                case "Sting":
                    return _conn.Query<Monsters>(query, new { action = "Sting" });
                case "Strength Drain":
                    return _conn.Query<Monsters>(query, new { action = "Strength Drain" });
                case "Tail":
                    return _conn.Query<Monsters>(query, new { action = "Tail" });
                case "Tentacles":
                    return _conn.Query<Monsters>(query, new { action = "Tentacles" });
                case "Touch":
                    return _conn.Query<Monsters>(query, new { action = "Touch" });
                case "Tusk":
                    return _conn.Query<Monsters>(query, new { action = "Tusk" });
                case "War Pick":
                    return _conn.Query<Monsters>(query, new { action = "War Pick" });
                case "Warhammer":
                    return _conn.Query<Monsters>(query, new { action = "Warhammer" });
                case "Withering Touch":
                    return _conn.Query<Monsters>(query, new { action = "Withering Touch" });
                default:
                    return Enumerable.Empty<Monsters>();
            }

        }
           public Monsters GetMonster(string monsterId)
        {
            return _conn.QuerySingle<Monsters>("SELECT * FROM Monsters WHERE MonsterId = @MonsterId", new { MonsterId = monsterId });
        }

        public IEnumerable<Monsters> SearchMonstersMeta(string meta)
        {
            string query = "SELECT * FROM Monsters WHERE Meta LIKE CONCAT('%', @meta, '%')";

            switch (meta)
            {
                case "Lawful Good":
                    return _conn.Query<Monsters>(query, new { meta = "lawful good" });
                case "Neutral Good":
                    return _conn.Query<Monsters>(query, new { meta = "neutral good" });
                case "Chaotic Good":
                    return _conn.Query<Monsters>(query, new { meta = "chaotic good" });
                case "Lawful Neutral":
                    return _conn.Query<Monsters>(query, new { meta = "lawful neutral" });
                case "Neutral":
                    return _conn.Query<Monsters>(query, new { meta = "neutral" });
                case "Chaotic Neutral":
                    return _conn.Query<Monsters>(query, new { meta = "chaotic neutral" });
                case "Lawful Evil":
                    return _conn.Query<Monsters>(query, new { meta = "lawful evil" });
                case "Neutral Evil":
                    return _conn.Query<Monsters>(query, new { meta = "neutral evil" });
                case "Chaotic Evil":
                    return _conn.Query<Monsters>(query, new { meta = "chaotic evil" });
                case "Unaligned":
                    return _conn.Query<Monsters>(query, new { meta = "unaligned" });
                default:
                    return Enumerable.Empty<Monsters>();
            }
        }

        public IEnumerable<Monsters> SearchMonstersChallenge(string challenge)
        {
            string query = "SELECT * FROM Monsters WHERE SUBSTRING_INDEX(Challenge, ' ', 1) = @challenge;";

            switch (challenge)
            {
                case "0":
                    return _conn.Query<Monsters>(query, new { challenge = "0" });
                case "1/8":
                    return _conn.Query<Monsters>(query, new { challenge = "1/8" });
                case "1/4":
                    return _conn.Query<Monsters>(query, new { challenge = "1/4" });
                case "1/2":
                    return _conn.Query<Monsters>(query, new { challenge = "1/2" });
                case "1":
                    return _conn.Query<Monsters>(query, new { challenge = "1" });
                case "2":
                    return _conn.Query<Monsters>(query, new { challenge = "2" });
                case "3":
                    return _conn.Query<Monsters>(query, new { challenge = "3" });
                case "4":
                    return _conn.Query<Monsters>(query, new { challenge = "4" });
                case "5":
                    return _conn.Query<Monsters>(query, new { challenge = "5" });
                case "6":
                    return _conn.Query<Monsters>(query, new { challenge = "6" });
                case "7":
                    return _conn.Query<Monsters>(query, new { challenge = "7" });
                case "8":
                    return _conn.Query<Monsters>(query, new { challenge = "8" });
                case "9":
                    return _conn.Query<Monsters>(query, new { challenge = "9" });
                case "10":
                    return _conn.Query<Monsters>(query, new { challenge = "10" });
                case "11":
                    return _conn.Query<Monsters>(query, new { challenge = "11" });
                case "12":
                    return _conn.Query<Monsters>(query, new { challenge = "12" });
                case "13":
                    return _conn.Query<Monsters>(query, new { challenge = "13" });
                case "14":
                    return _conn.Query<Monsters>(query, new { challenge = "14" });
                case "15":
                    return _conn.Query<Monsters>(query, new { challenge = "15" });
                case "16":
                    return _conn.Query<Monsters>(query, new { challenge = "16" });
                case "17":
                    return _conn.Query<Monsters>(query, new { challenge = "17" });
                case "18":
                    return _conn.Query<Monsters>(query, new { challenge = "18" });
                case "19":
                    return _conn.Query<Monsters>(query, new { challenge = "19" });
                case "20":
                    return _conn.Query<Monsters>(query, new { challenge = "20" });
                case "21":
                    return _conn.Query<Monsters>(query, new { challenge = "21" });
                case "22":
                    return _conn.Query<Monsters>(query, new { challenge = "22" });
                case "23":
                    return _conn.Query<Monsters>(query, new { challenge = "23" });
                case "24":
                    return _conn.Query<Monsters>(query, new { challenge = "24" });
                case "25":
                    return _conn.Query<Monsters>(query, new { challenge = "25" });
                case "26":
                    return _conn.Query<Monsters>(query, new { challenge = "26" });
                case "27":
                    return _conn.Query<Monsters>(query, new { challenge = "27" });
                case "28":
                    return _conn.Query<Monsters>(query, new { challenge = "28" });
                case "29":
                    return _conn.Query<Monsters>(query, new { challenge = "29" });
                case "30":
                    return _conn.Query<Monsters>(query, new { challenge = "30" });
                default:
                    return Enumerable.Empty<Monsters>();
            }

        }
    }
}
