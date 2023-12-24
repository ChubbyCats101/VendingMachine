using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class WaterMachine
    {
        int water;
        int coffee;
        int Coco;
        int Milk;

        public WaterMachine()
        {
            water = 1000;
            coffee = 1000;
            Coco = 1000;
            Milk = 1000;
        }

        public bool MakeBlackCoffee()
        {
            if (water >= 300 && coffee >= 20)
            {
                // make blackCoffee
                water = water - 300;
                coffee = coffee - 20;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool MakeMocha()
        {
            if (water >= 300 && coffee >= 20 && Coco >= 10)
            {
                //make Mocha
                water = water - 300;
                coffee = coffee - 20;
                Coco = Coco - 10;
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Makelatte()
        {
            if (water >= 300 && coffee >= 20 && Milk >= 10)
            {
                //make latte
                water = water - 300;
                coffee = coffee - 20;
                Milk = Milk - 10;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MakeHotchocolate()
        {
            if (water >= 300 && Coco >= 20)
            {
                //make Hotchocolate
                water = water - 300;
                Coco = Coco - 20;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Restock()
        {
            water = 1000;
            coffee = 1000;
            Coco = 1000;
            Milk = 1000;

            return 1000;

        }

        public int GetRestock()
        {
            return Restock();
        }

    }
}
