using System;
using System.Collections.Generic;
using System.Text;

namespace RPR
{
    class Archetype
    {
        private DBItem item;
        private bool hero;
        private bool villain;
        private bool praetorian;

        public bool Hero { get => hero; set => hero = value; }
        public bool Villain { get => villain; set => villain = value; }
        public bool Praetorian { get => praetorian; set => praetorian = value; }
        internal DBItem Item { get => item; set => item = value; }

        public Archetype(string newItem, int newId, bool newHero, bool newVillain, bool newPraet)
        {
            Item = new DBItem(newItem, newId);
            Hero = newHero;
            Villain = newVillain;
            Praetorian = newPraet;
        }
    }
}
