using System;
using System.Collections.Generic;
using System.Text;

namespace RPR
{
    class DBItem
    {
        private string itemName;
        private int itemId;

        public string ItemName { get => itemName; set => itemName = value; }
        public int ItemId { get => itemId; set => itemId = value; }

        public DBItem()
        {
            ItemName = "";
            ItemId = 0;
        }

        public DBItem(string newName, int newId)
        {
            ItemName = newName;
            ItemId = newId;
        }
    }
}
