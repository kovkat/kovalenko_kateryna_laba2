using System;
namespace Laba2._1
{
    class Program
    {
        public class Piano
        {
            public static System.Collections.ArrayList piano = new System.Collections.ArrayList();
            public string name, part;

            public void Setting()
            {
                Console.Write(String.Format("What {0} you want to use?", this.part));
                this.name = Console.ReadLine();
                Console.WriteLine();
                piano.Add(this);
            }

            public void Press()
            {
                Console.WriteLine("Enter part of piano you want to press:");
                string part = Console.ReadLine();
                if (part == "key")
                {
                    Key key = new Key(part);
                    key.Setting();
                }
                else
                {
                    if (part == "pedal")
                    {
                        Pedal pedal = new Pedal(part);
                        pedal.Setting();
                    }
                    else
                    {
                        Console.WriteLine("Error!");

                    }
                }
                piano.Add(this);
            }

            public void Play()
            {
                Console.WriteLine("Your song:");
                for (int i = 0; i < piano.Count; i++)
                {
                    Console.WriteLine(piano[i].ToString());

                }
            }



            public override string ToString()
            {
                return this.part + " " + this.name;
            }
        }

        public class Key : Piano
        {
            public Key(string part)
            {
                this.part = part;
            }
        }
        public class Pedal : Piano
        {
            public Pedal(string part)
            {
                this.part = part;
            }
        }
        static void Main(string[] args)
        {
            System.Collections.ArrayList song = Piano.piano;
            Console.WriteLine("How many times you want to use the piano?");
            int times = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                Piano.Press();
            }
            Piano.Play();
        }
    }

}
