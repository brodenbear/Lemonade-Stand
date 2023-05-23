using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    internal class Customer
    {

        public bool willingToBuy = false;
        public int money = 20;

        public Customer(bool willingToBuy, int money)
        {
            this.willingToBuy = willingToBuy;
            this.money = money;
        }
        public void Purchase(int transactionAmount)
        {
            if (this.willingToBuy == true && this.money >=0) 
            { 
            willingToBuy = true;
            this.money -= transactionAmount;
            }
            else
            {
                willingToBuy = false;
            }
        }       
    }
}
