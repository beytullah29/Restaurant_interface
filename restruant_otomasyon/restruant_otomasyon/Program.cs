using System;
using System.Collections.Generic;

namespace restruant_otomasyon
{
    class Program
    {
        static void Main(string[] args)
        {

            IRestaurantFace Esnaf = new EsnafRestaurant();
            bool WhileBool = true;
            Console.Write("Restaurant name   :  ");
            string RestruantText = Console.ReadLine().ToString().Trim().ToLower();
            switch (RestruantText)
            {
                case "esnaf":
                    while (WhileBool)
                    {
                        Console.Write("what is food name  :  ");
                        string FoodEatName = Console.ReadLine().ToString().Trim().ToLower();
                        try
                        {
                            Console.Write("how much does food coast   :  ");
                            int FoodEatPiece = int.Parse(Console.ReadLine());
                            Esnaf.Add(FoodEatName, FoodEatPiece);

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("piece is wrong");
                        }
                        finally
                        {
                            Console.Write("Başka bir Yemek eklemek için  yoksa (y/n)   :  ");
                            string continues = Console.ReadLine().Trim().ToLower().ToString();
                            if (continues!="y")
                            {
                                WhileBool = false;
                            }
                            else
                            {
                                for (int i = 0; i < 3; i++)
                                {
                                    Console.WriteLine("*****************");
                                }
                               
                            }
                                 
                          
                        }

                    }
                    int pieces = Esnaf.paid();
                    Console.WriteLine(pieces);
                    break;
            }


         


        }
    }
 

    interface IRestaurantFace
    {

        int price { get; set; }
        int paid();
        void Add(string FoodName, int FoodPiece);

    }

    class EsnafRestaurant : IRestaurantFace
    {
        Dictionary<string, int> FoodANdPiece = new Dictionary<string, int>();
        public int price { get; set; }
        public void Add(string FoodName, int FoodPiece)
        {
            FoodANdPiece.Add(FoodName, FoodPiece);
        }
        public int paid()
        {
            foreach (var item in FoodANdPiece.Values)
            {
                price += item;
            }

            return price;

        }

    }
}


