using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class RollOneRandom
    {

        private int NumberOfSides;
        private int Die;

        public RollOneRandom(int sides)     //constructor
        {
            sides = NumberOfSides;
        }
        #region ENCAPSULATED (get/set)
        public int NumberOfSides1       //Encapsulated get/set
        {
            get
            {
                return NumberOfSides;
            }

            set
            {
                NumberOfSides = value;
            }
        }

        public int Die1
        {
            get
            {
                return Die1;
            }

            set
            {
                Die1 = value;
            }
        }
        #endregion

        //public int NextTrial(int sides)         // method to roll 1 random
        //{
        //    Random r = new Random();
        //    sides = NumberOfSides1;
        //    int roll = r.Next(1, sides + 1);
        //    return roll;         

        //}
        private int Roll(int sides)
        {
            Random r = new Random();
            int Die = r.Next(1, sides + 1);
            return Die;
        }

        public static implicit operator Random(RollOneRandom v)
        {
            throw new NotImplementedException();
        }
    }
}
