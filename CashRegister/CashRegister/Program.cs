using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashRegister
{
    public class Program
    {
        protected string item_name;
        protected double item_price;
        protected int item_quantiy;
        protected double total_price;

        public Program(string name, double price, int quantity)
        {
            this.item_name = name;
            this.item_price = price;
            this.item_quantiy = quantity;
            this.total_price = price + quantity;
        }
        static void Main(string, double, int quantity)[] args){
            }

        public double getTotalPrice()
        {

            return total_price;
        }

    }
}