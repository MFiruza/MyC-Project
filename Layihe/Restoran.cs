using System;
using System.Collections.Generic;
using System.Text;

namespace Layihe
{
    class Restoran

    {

        private string _restoranName { get; set; }
        private List<Food> menu;
       


        public Restoran(string RestoranName,List<Food> Menu)
        {
            this._restoranName = RestoranName;
            this.menu = Menu;
      
        }

        public string RestoranName { get { return this._restoranName; } }

        


        public void AddFood(string addfoodname,byte addquantity)
        {
            Food addfindname = menu.Find(f => f.FoodName.ToLower() == addfoodname.ToLower());
            if (addfindname!=null)
            {
                addfindname.UpdatedQuantity(addquantity);
                Console.WriteLine();
                Console.WriteLine("Əlavə olundu");
                Console.WriteLine();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            }

            else
            {
                Food newFood = new Food(addfoodname, addquantity);
                menu.Add(newFood);
                Console.WriteLine();
                Console.WriteLine(".......................");
                Console.WriteLine("Yeni yemək əlave olundu");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine();
            }
        }
        public void ShowMenu (){
            foreach (var food in menu)
            {
                food.FullInfo();
            }
        }
        
       public void OrderFood(Food result,byte orderquantity)
        {
           
                        if (result.Quantity >=orderquantity)
                        {
                            result.OrderQuantity(orderquantity);
                            Console.WriteLine("......");
                            Console.WriteLine("Sifariş qəbul edildi");
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~");
                        }
                        else
                        {
                            Console.WriteLine(".......");
                            Console.WriteLine("Qeyd etdiyini miqdar möcud miqdarı aşır");
                            Console.WriteLine();
                            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                        }
                    
                   
                    
                
        }



    }
}
