using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Elevator
    {
        private double MaxWeight;
        private Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            MaxWeight = maxWeight;

        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;
        }

        public double GetCurrentWeight()
        {
            double totalWeight = 0;

            for (int i = 0; i < Occupants.Length; i++)
            {
                Passenger p = Occupants[i];
                if (p != null)
                {
                    totalWeight += p.GetWeight();
                }
            }

            return totalWeight;
        }

        public bool IsOverMaxCapacity()
        {      

            if (GetCurrentWeight() > MaxWeight)
            {
                return true;

            }
            else
            {
                return false;
    
            }
     
        }


    }
}
