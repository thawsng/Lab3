using System;

namespace La3_2
{
    public class Atom
    {
        public int Number { get; set; }
        string Symbol { get; set; }
        string FullName { get; set; }
        float Weight { get; set; }

        public bool Accept()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Enter atomic number: ");
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        Number = number;
                        if (Number == 0)
                        {
                            return false;
                        }

                        break;
                    }
                }
                Console.WriteLine("Enter symbol: ");
                Symbol = Console.ReadLine();
                Console.WriteLine("Enter full name: ");
                FullName = Console.ReadLine();
                while (true)
                {
                    Console.Write("Enter atomic weight: ");
                    if (float.TryParse(Console.ReadLine(), out var number))
                    {
                        Weight = number;
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return true;
        }

        public void Display()
        {
            Console.WriteLine($"{Number} {Symbol} {FullName} {Weight}");
        }
    }
    
}