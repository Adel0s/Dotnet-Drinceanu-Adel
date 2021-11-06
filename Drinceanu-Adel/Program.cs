using System;
using System.Linq;

namespace Drinceanu_Adel
{
    class Program //clasa
    {
        static void Main(string[] args) //metoda
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            int x = 19;
            Console.WriteLine("My age is " + x);

            int a = 5;

            int[] v = { -5, 5, 6, 7 };
            int[] v1 = v;
            v[0] = 9;

            Console.WriteLine(v[0]);
            Console.WriteLine(v1[0]);

            //vid 12
            int i = (int)12.9999;
            double d = 5.8127;
            Console.WriteLine(i);
            Console.WriteLine(d);

            //vid 13
            decimal dec = 10.5M; //mai precis decat double
            Console.WriteLine(dec);

            double nn = double.NaN;
            Console.WriteLine("Is not a number? " + double.IsNaN(nn));
            double inf = double.PositiveInfinity;
            Console.WriteLine(inf);

            //vid 14
            double f = 50.5;
            double ff = 100;
            Console.WriteLine(Math.Round(f));
            Console.WriteLine(Math.Round(f,0,MidpointRounding.AwayFromZero));
            Console.WriteLine(Math.Floor(f));
            Console.WriteLine(Math.Ceiling(f));
            Console.WriteLine(Math.Truncate(f));
            Console.WriteLine("Max value is " + Math.Max(f,ff));
            Console.WriteLine("Min value is " + Math.Min(f, ff));

            //vid 15
            char letter = 'b';
            int number = 'a';
            Console.WriteLine(letter);
            Console.WriteLine("ASCII TABLE dec value is " + number);
            char special = (char)900;
            Console.WriteLine(special);

            //vid 16
            string name1 = "Adel";
            string name2 = name1;
            name1 = name1 + " Drinceanu"; // name1 += " Drinceanu"
            Console.WriteLine(name1);
            Console.WriteLine(name2);

            char[] charcaters = { 's', 'a', 'l', 'u', 't' };
            string greeting = new string(charcaters);
            Console.WriteLine(greeting);

            string message = $"Hello my name is {name}, and I like to say {greeting}";
            Console.WriteLine(message);

            //vid 17
            string name3 = "Adedel";
            Console.WriteLine(name3.Trim());
            int name1Length = name3.Length;
            Console.WriteLine(name3.CompareTo("Adel"));
            int findChar = name.IndexOf("de");
            Console.WriteLine(findChar);
            Console.WriteLine(name3.Remove(1,2));

            string s1 = "hello my name is Adel";
            string[] words = s1.Split(' ');
            Console.WriteLine(words[1]);

            //vid 18
            string esc = " 'Hello' \"World!\" My name \\is \tAdel";
            Console.WriteLine(esc);

            char letter1 = '\'';
            Console.WriteLine(letter1);

            //vid 19
            Person person = new Person();
            person.FirstName = "Adel";
            person.LastName = "Drinceanu";
            Console.WriteLine(person.GetFullName());
            Console.WriteLine(person.FullName);

            //vid 20
            string password = "1234";
            Console.WriteLine("Enter the password: ");
            string yourPassword = Console.ReadLine();
            if(yourPassword == password)
            {
                Console.WriteLine("Right password");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }

            //vid 21
            int age = Int32.Parse(Console.ReadLine());
            if(age > 12 && yourPassword == password)
            {
                Console.WriteLine("Welcome! You are atleast a teenager and got correct password");
            }

            //vid 22
            string nameSwitch = "Adel";
            switch(nameSwitch)
            {
                case "Adel":
                    Console.WriteLine("Esti tare!");
                    break;
                case "Claire":
                    Console.WriteLine("Esti slab!");
                    break;
                default:
                    Console.WriteLine("Cine esti?");
                    break;
            }

            int numberSwitch = 3;
            switch (numberSwitch)
            {
                case 1:
                    Console.WriteLine("Esti tare!");
                    break;
                case 3:
                    Console.WriteLine("Esti slab!");
                    break;
                default:
                    Console.WriteLine("Cine esti?");
                    break;
            }

            //vid 23-24
            bool correct = true;
            int pointsEarned = correct ? 10 : 0;

            Console.WriteLine(pointsEarned);

            //echivalent cu if:
            /*if(correct)
            {
                pointsEarned = 10;
            }
            else
            {
                pointsEarned = 0;
            }*/

            //vid 25
            int ii = 0;
            while(ii<10)
            {
                Console.WriteLine(ii);
                ii++;
            }

            //vid 26
            do
            {
                Console.WriteLine(ii);
                ii++;
            } while (ii < 0);

            //vid 27
            for(int k = 1; k<10; k++)
            {
                Console.WriteLine(k);
            }

            for (int k = 10; k > 0; k-=2)
            {
                Console.WriteLine(k);
            }

            //vid 28
            bool logging = true;
            for (int k = 1; k < 10; k++)
            {
                if(k==9)
                { 
                    if(logging)
                    {
                        Console.WriteLine("We found 9!");
                    }
                }
            }

            //vid 29
            for (int k = 1; k < 10; k++)
            {
                for(int l = k; l<10; l++)
                {
                    Console.Write(l + " ");
                }
                Console.WriteLine();
            }

            //vid 30
            int j = 9;
            while (j >= 0)
            {
                int k = j;
                while(k>=0)
                {
                    Console.Write(k + " ");
                    k--;
                }
                Console.WriteLine();
                j--;
            }

            //vid 32
            for (int k = 1; k < 10; k++)
            {
                for ( j = k; j < 10; j++)
                {
                    if(j==3)
                    {
                        break;
                    }
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //vid 33
            for (int k = 1; k < 10; k++)
            {
                if(k == 8)
                {
                    continue;
                }
                for (j = k; j < 10; j++)
                {
                    if (j == 3)
                    {
                        continue;
                    }
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            //vid 35 - 36
            int size = Convert.ToInt32(Console.In.ReadLine());
            int[] grades = new int[10];

            Console.WriteLine(grades[size]);

            for(i=0; i < grades.Length; i++)
            {
                grades[i] = Convert.ToInt32(Console.In.ReadLine());
            }

            for (i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i] + " ");
            }

            //vid 37
            bool found = false;
            for (i = 0; i < grades.Length; i++)
            {
                if(grades[i] == 40)
                {
                    Console.WriteLine("We found it!");
                    found = true;
                    break;
                }
            }
            if(!found)
            {
                Console.WriteLine("Not found :( ");
            }

            Console.WriteLine(Array.IndexOf(grades, 23));

            //vid 38
            int[] toSortArray = { 900, 30, 27, 90 };
            Array.Sort(grades);

            //vid 39
            Array.Reverse(grades);

            int[] grades1 = { 900, 34, 300, 18 };
            int[] grades2 = { 900, 34, 300, 18 };

            if (Enumerable.SequenceEqual(grades1, grades2))
            {
                Console.WriteLine("Equal");
            }

            //vid 40 41
            int[,] array_2D = new int[3, 4];
            array_2D[0, 2] = 5;
            Console.WriteLine(array_2D[0, 2]);

            int[,] array_2D1 = new int[3, 4]
            {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}
            };
            Console.WriteLine(array_2D1[0, 2]);

            int[][] jaggedArray = { 
                new int[] { 1 },
                new int[] { 1, 2 },
                new int[] { 1, 2, 3 }
            };
            Console.WriteLine(jaggedArray[2][1]);

            //vid 42
            Console.WriteLine(jaggedArray.Length);
            Console.WriteLine(jaggedArray[1].Length);

            for(i = 0; i<jaggedArray.Length;i++)
            {
                for(j=0;j<jaggedArray[i].Length;j++)
                {
                    Console.WriteLine(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(array_2D1.GetLength(0));
            Console.WriteLine(array_2D1.GetLength(1));

            for (i = 0; i < array_2D1.GetLength(0); i++)
            {
                for (j = 0; j < array_2D1.GetLength(1); j++)
                {
                    Console.WriteLine(array_2D1[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
