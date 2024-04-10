namespace DungeonsAndDragonsMonsterFinder.Models
{
    public class Monsters
    {
        public Monsters()
        {

        }
        public int MonsterId { get; set; }
        public string Name { get; set; }
        public string Meta { get; set; }
        public string ArmorClass { get; set; }
        public string HitPoints { get; set; }
        public string Speed { get; set; }
        public int STR { get; set; }
        public string STR_mod { get; set; }
        public int DEX { get; set; }
        public string DEX_mod { get; set; }
        public int CON { get; set; }
        public string CON_mod { get; set; }
        public int INT { get; set; }
        public string INT_mod { get; set; }
        public int WIS { get; set; }
        public string WIS_mod { get; set; }
        public int CHA { get; set; }
        public string CHA_mod { get; set; }
        public string SavingThrows { get; set; }
        public string Skills { get; set; }
        public string Senses { get; set; }
        public string Languages { get; set; }
        public string Challenge { get; set; }
        public string Traits { get; set; }
        public string Actions { get; set; }
        public string LegendaryActions { get; set; }
        public string img_url { get; set; }
        public string DamageImmunities { get; set; }
        public string ConditionImmunities { get; set; }
        public string DamageResistances { get; set; }
        public string DamageVulnerabilities { get; set; }
        public string Reactions { get; set; }
    }

}
