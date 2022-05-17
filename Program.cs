using System;
using System.Collections.Generic;

namespace laba2._2
{
    class Program
    {
		public class Stones
		{
			public string name_of_stone;
			public int weight_in_carats;
			public int price_per_carat;
			public string transparency_range;
			public int number;


			public Stones(string name, int weight, int price, string transperency, int numb)
			{
				name_of_stone = name;
				weight_in_carats = weight;
				price_per_carat = price;
				transparency_range = transperency;
				number = numb;

			}
			public static List<Stones> necklace =
				new List<Stones>();

			public static void Create_Necklace()
			{
				Console.WriteLine("Choose what gems you want to see in your necklace:");
				string name_of_stone = Console.ReadLine();
				if (name_of_stone == "emerald")
				{
					Console.WriteLine("How many stones of this type you want:");
					int em = Convert.ToInt32(Console.ReadLine());
					Emerald emerald = new Emerald("emerald", 4, 100, "transperent", em);
					necklace.Add(emerald);
				}
				else if (name_of_stone == "nephrite")
				{
					Console.WriteLine("How many stones of this type you want:");
					int nep = Convert.ToInt32(Console.ReadLine());
					Nephrite nephrite = new Nephrite("nephrite", 5, 50, "opaque", nep);
					necklace.Add(nephrite);
				}
				else if (name_of_stone == "malachite")
				{
					Console.WriteLine("How many stones of this type you want:");
					int mal = Convert.ToInt32(Console.ReadLine());
					Malachite malachite = new Malachite("malachite", 3, 75, "translucent", mal);
					necklace.Add(malachite);
				}
				else
				{
					Console.WriteLine("Error!");
				}
			}

			public static void Our_Necklace()
			{
				Console.WriteLine();
				Console.WriteLine("Necklace:");
				for (int i = 0; i < necklace.Count; i++)
				{
					Console.WriteLine(necklace[i].name_of_stone + " - " + necklace[i].number + " stone(s) - " + necklace[i].weight_in_carats + " carats - "

					 + necklace[i].price_per_carat + " $");
				}
			}

			public static void Weight_Price()
			{
				Console.WriteLine();
				int summ_weight = 0;
				int summ_price = 0;
				for (int i = 0; i < necklace.Count; i++)
				{
					summ_weight += necklace[i].number * necklace[i].weight_in_carats;
					summ_price += necklace[i].number * necklace[i].weight_in_carats * necklace[i].price_per_carat;
				}
				Console.WriteLine("Summary weight: " + summ_weight + " carats");
				Console.WriteLine("Summary price: " + summ_price + " $");
				Console.WriteLine();
			}

			public static void Sort()
			{
				for (int i = necklace.Count - 1; i > -1; i--)
				{
					for (int j = 0; j < i; j++)
					{
						if (necklace[j].price_per_carat > necklace[j + 1].price_per_carat)
						{
							(necklace[j], necklace[j + 1]) = (necklace[j + 1], necklace[j]);
						}
					}
				}
				for (int i = 0; i < necklace.Count; i++)
				{
					Console.WriteLine(necklace[i].name_of_stone + " " + necklace[i].price_per_carat + " $");
				}
			}

			public static void Find()
			{
				bool flag = false;
				Console.WriteLine();
				Console.WriteLine("Enter diapasone, what you need: ");
				string diapasone = Console.ReadLine();
				for (int i = 0; i < necklace.Count; i++)
				{
					if (diapasone == necklace[i].transparency_range)
					{
						Console.WriteLine("Result: " + necklace[i].name_of_stone);
						flag = true;
					}
				}
				if (flag == false)
				{
					Console.WriteLine("Error!");
				}

			}

		}

		internal class Emerald : Stones
		{
			public Emerald(string name, int weight, int price, string transperency, int numb)
				: base(name, weight, price, transperency, numb)
			{
			}
		}

		internal class Malachite : Stones
		{
			public Malachite(string name, int weight, int price, string transperency, int numb)
				: base(name, weight, price, transperency, numb)
			{
			}
		}
		internal class Nephrite : Stones
		{
			public Nephrite(string name, int weight, int price, string transperency, int numb)
				: base(name, weight, price, transperency, numb)
			{
			}
		}
	}

	static void Main(string[] args)
        {
            
            Console.WriteLine("How many types of stones you want?");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Stones.Create_Necklace();
            }
            Stones.Our_Necklace();
            Stones.Weight_Price();
            Stones.Sort();
            Stones.Find();
            Console.ReadKey();
        }
           
        
    }
}