namespace RPR
{
    class Character
    {
        private DBItem archetype;
        private DBItem origin;
        private DBItem[] powersets;
        private Power[] powers;

        internal DBItem Archetype { get => archetype; set => archetype = value; }
        internal DBItem Origin { get => origin; set => origin = value; }
        internal DBItem[] Powersets { get => powersets; set => powersets = value; }
        internal Power[] Powers { get => powers; set => powers = value; }

        public Character()
        {
            Archetype = new DBItem();
            Origin = new DBItem();
            Powersets = new DBItem[2];
            Powers = new Power[24];
        }
    }
}
