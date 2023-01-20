using System;

namespace AssigmentTest
{
    class Program
    {
        static void Main(string[] args)
        {
        Begin:
            #region

            Console.Clear();
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("---------DAFTAR SOAL--------- \n");
            Console.WriteLine("-------------------------------------- \n" +
            "Soal no. 1(1) \n" +
            "Soal no. 2(2) \n");
            Console.Write("Masukan Nomer Soal : ");
            int exam = Convert.ToInt16(Console.ReadLine());

            if (exam == 1)
            {
                Exam001();
            }
            else if (exam == 2)
            {
                Exam002();
            }

            #endregion

            #region Restart Program
            Console.WriteLine("\nApakah anda ingin merunning program? (y / n)");
            string ans = Console.ReadLine().ToLower();

            if (ans.Equals("y"))
            {
                goto Begin;
            }
            else
            {
                Environment.Exit(1);
            }

            #endregion
        }
            public static void Exam001()
            {
            Console.Write("Masukan Input \t: ");
           
            bool prima = true;

            int input = Convert.ToInt32(Console.ReadLine());

            if (input >= 2)
            {
                for (int i = input; i >= 2; i--)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            prima = false;
                            break;
                        }
                    }

                    if (prima)
                    Console.WriteLine("Bilangan " + i + " adalah bilangan prima");
                    prima = true;
                }
            }
        }

        public static void Exam002()
        {
            int a, b, c,d;
            Console.Write("Masukan Input \t: ");
            a = Convert.ToInt32(Console.ReadLine());

            for (b=1; b<=a;b++)
            {
                for (d=1; d<=a-b; d++)
                {
                    Console.Write(" ");
                }
                for (c = 1; c <= b; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

    }
}
