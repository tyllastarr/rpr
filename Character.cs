namespace RPR
{
    public enum Alignment
    {
        Hero,
        Villain,
        Praetorian,
        Praetorian_Hero,
        Praetorian_Villain
    }
    class Character
    {
        private DBItem archetype;
        private DBItem origin;
        private Alignment align;
        private DBItem[] powersets;
        private Power[] powers;

        internal DBItem Archetype { get => archetype; set => archetype = value; }
        internal DBItem Origin { get => origin; set => origin = value; }
        internal DBItem[] Powersets { get => powersets; set => powersets = value; }
        internal Power[] Powers { get => powers; set => powers = value; }
        public Alignment Align { get => align; set => align = value; }

        public Character()
        {
            Archetype = new DBItem();
            Origin = new DBItem();
            Powersets = new DBItem[2];
            Powers = new Power[24];
        }
    }
}
