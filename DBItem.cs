using System;
using System.Collections.Generic;
using System.Text;

namespace RPR
{
    class DBItem
    {
        private String itemName;
        private int itemId;

        public string ItemName { get => itemName; set => itemName = value; }
        public int ItemId { get => itemId; set => itemId = value; }
    }
}
