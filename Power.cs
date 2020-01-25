using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RPR
{
    class Power
    {
        private String powerName;
        private int numSlots;

        public String getPowerName()
        {
            return powerName;
        }

        public void setPowerName(String newName)
        {
            powerName = newName;
        }

        public int getNumSlots()
        {
            return numSlots;
        }

        public void setNumSlots(int newNum)
        {
            if(newNum > 6)
            {
                Debug.Print("Number of slots too high.");
            } else if(newNum < 1)
            {
                Debug.Print("Number of slots too low.");
            } else
            {
                numSlots = newNum;
            }
        }
    }
}
