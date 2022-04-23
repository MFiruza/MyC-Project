using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe
{
    class Food//Food class kimi tesvir edin
    {
        private string _foodname;
        private byte _quantity;
        public Food( string FoodName, byte Quanyity)
        {
            this._quantity = Quanyity;
            this._foodname = FoodName;
           
        }

        public string FoodName { get { return this._foodname; } }
        public byte Quantity { get { return this._quantity; } }

        public void FullInfo()
        {
            Console.WriteLine($"{this.FoodName}  | Miqdar: {this.Quantity}");
        }

        public byte UpdatedQuantity( byte quantity)
        {


           return this._quantity += quantity;

        }

        public byte OrderQuantity(byte quantity)
        {


            return this._quantity -= quantity;

        }

    }
}
