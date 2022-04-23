using System;
using System.Collections.Generic;

namespace Layihe
{
    class Program
    {
        static void Main(string[] args)
        {
        
                       Console.OutputEncoding = System.Text.Encoding.UTF8;



            #region Restoran

            byte choice;
            bool choiceisNumber;
            List<Food> menu = new List<Food>();
            Restoran restoran = new Restoran("A restoran", menu);
            Food food1 = new Food("Salat", 50);
            Food food2 = new Food("Kabab", 10);
            Food food3 = new Food("Burger", 50);
            Food food4 = new Food("Pizza", 50);
            menu.Add(food1);
            menu.Add(food2);
            menu.Add(food3);
            menu.Add(food4);
            Console.WriteLine("Salam, Xoşgəldiniz");
            Console.WriteLine();
            do
            {
                Console.WriteLine("Aşağıdakı seçimlərdən birini edin");
                Console.WriteLine();
                Console.WriteLine("1.Menyuya əlavə etmək");
                Console.WriteLine("2. Menyunu göstərmək");
                Console.WriteLine("3.Sifariş");
                Console.WriteLine("0.Çıxmaq");
                Console.Write("Seçim: ");
                choiceisNumber = Byte.TryParse(Console.ReadLine(), out choice);
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine();
                if (choiceisNumber)
                {
                    if (choice==1||choice==2||choice==3||choice==0)
                    {
                          if (choice == 1)
                          {
                            Console.Write("Adı : ");
                            string foodName = Console.ReadLine();

                           
                                Console.Write("Miqdarı: ");
                                bool quanytityisNumber = Byte.TryParse(Console.ReadLine(), out byte addQuanytity);
                                if (quanytityisNumber)
                                {
                                    restoran.AddFood(foodName, addQuanytity);
                                }

                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("====================Düzgün məlumat daxil edin!=====================");
                                    Console.WriteLine();
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                }
                            
                          }
                            if (choice == 2)
                            {
                                Console.WriteLine("==============>MENYU<================");
                                Console.WriteLine();
                                restoran.ShowMenu();
                                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                Console.WriteLine();
                            }

                            else if (choice == 3)
                            {
                            Console.WriteLine("==============>SİFARİŞ<================");
                            Console.WriteLine();
                            Console.Write("İstədiyinizi qeyd edin:  ");
                                string ordername = Console.ReadLine();
                              
                           
                                Food result = menu.Find(f => f.FoodName.ToLower() == ordername.ToLower());
                                if (result != null)
                                {
                                    if (result.Quantity > 0)
                                    {
                                        Console.Write("Miqdarını qeyd edin: ");
                                        bool isbyteorder = Byte.TryParse(Console.ReadLine(), out byte orderquantity);
                                        if (isbyteorder)
                                        {

                                            restoran.OrderFood(result, orderquantity);
                                        }
                                        else
                                        {
                                            Console.WriteLine("Düzgun məlumat daxil edin!");
                                        }

                                    }

                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("......");
                                        Console.WriteLine($"{result.FoodName} artıq bitibdir");
                                        Console.WriteLine();
                                        Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                                    }

                                }


                                else
                                {
                                    Console.WriteLine();
                                    Console.WriteLine($"{ordername} menyuda yoxdur");
                                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
                                    Console.WriteLine();
                                }
                            
                   
                             
                              
                            }
                            else if(choice==0){
                                choice = 0;
                                Console.WriteLine("........");
                                Console.WriteLine("Exit");
                            }

                            else
                            {
                                Console.WriteLine("Siyahıdakı seçimləri daxil edin");
                            }
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Zəhmət olmasa seçimlərdən birini daxil edin!");
                        Console.WriteLine();
                    }
                   
                  
                    

                }
                else
                {
                    choice = 99;
                    Console.WriteLine("Seçimlərdən birini daxil edin");
                    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                    Console.WriteLine();
                }


            } while (choice != 0);



            #endregion

        }
    }
}
