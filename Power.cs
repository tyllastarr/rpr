using System;

namespace RPR
{
    class Power
    {
        private DBItem powerItem;
        private int numSlots;

        public int NumSlots { get => numSlots; set => numSlots = value; }
        internal DBItem PowerItem { get => powerItem; set => powerItem = value; }

        public Power(int newId, String newName, int newNum)
        {
            PowerItem = new DBItem();
            PowerItem.ItemId = newId;
            PowerItem.ItemName = newName;

            if (newNum > 6 || newNum < 1)
            {
                NumSlots = 1;
            }
            else
            {
                NumSlots = newNum;
            }
        }

        public Power(String newName, int newNum)
        {
            PowerItem = new DBItem();
            PowerItem.ItemName = newName;

            if (newNum > 6 || newNum < 1)
            {
                NumSlots = 1;
            }
            else
            {
                NumSlots = newNum;
            }
        }

        public Power(int newId, String newName)
        {
            PowerItem = new DBItem();
            PowerItem.ItemId = newId;
            PowerItem.ItemName = newName;
            NumSlots = 1;
        }

        public Power(String newName)
        {
            PowerItem = new DBItem();
            PowerItem.ItemName = newName;
            NumSlots = 1;
        }

        public Power()
        {
            PowerItem = new DBItem();
            NumSlots = 1;
        }
    }
}
