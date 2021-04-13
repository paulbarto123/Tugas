using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
            int i = 1;
            string yesDefault = "YES";
            while (i > 0)
            {
                Console.WriteLine("Type Yes To Restart The Programm\n ");
                string YesConfirm = Console.ReadLine();
                if (yesDefault.Equals(YesConfirm, StringComparison.CurrentCultureIgnoreCase))
                {
                    StartProgram();
                }
                else
                {
                    break;
                    //Environment.Exit(-1);
                }

            }
        }
        static void StartProgram()
        {
            Console.WriteLine("Welcome to This Application ");
            Console.WriteLine("ENjoy");
            Console.WriteLine("Everybody");
            Console.WriteLine("Input Number From 1-4\n" +
                "1. Body Mass Index\n" +
                "2. Reprint Name\n" +
                "3. Print Even's Character\n" +
                "4. Sum Inputted Array ");
            int pilihan = int.Parse(Console.ReadLine());
            switch (pilihan)
            {
                case 1:
                    BMI();
                    break;
                case 2:
                    ReprintName();
                    break;
                case 3:
                    PrintEvenCharacter();
                    break;
                case 4:
                    SumInputtedArray();
                    break;
                default:
                    Console.WriteLine("Please Input Number From 1-4");
                    break;
            }
        }
        static void BMI()
        {
            Console.Write("Input Your Weight (kg) \n");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Input Your Height (cm)");
            float m = (float.Parse(Console.ReadLine())) / 100;
            float bmi = n / (m * m);
            if (bmi < 18.1)
            {
                Console.WriteLine("Your BMI's {0} You're Underweight", bmi);
            }
            else if (bmi >= 18.1 && bmi < 23.1)
            {
                Console.WriteLine("Your BMI's {0} You're Normal", bmi);
            }
            else if (bmi >= 23.1 && bmi <= 28.1)
            {
                Console.WriteLine("Your BMI's {0} You're Overweight", bmi);
            }
            else
            {
                Console.WriteLine("Your BMI's {0} You're Obese", bmi);

            }
            //else if (bmi >= 30 && bmi < 35)
            //{
            //    Console.WriteLine("Your BMI's {0} You're Obese", bmi);
            //}
            //else if (bmi >= 35 && bmi < 40)
            //{
            //    Console.WriteLine("Your BMI's {0} You're Very Obese", bmi);
            //}

        }
        static void ReprintName()
        {
            Console.WriteLine("Please Input Your Name");
            String nama = Console.ReadLine();
            for (int i = 0; i < nama.Length; i++)
            {
                Console.WriteLine("Huruf Ke {0} adalah {1}", i + 1, nama[i]);
            }
        }

        static void PrintEvenCharacter()
        {
            Console.WriteLine("Please Input Your Name");
            String nama = Console.ReadLine();
            for (int i = 0; i < nama.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(nama[i]);
                }
            }
        }
        static void SumInputtedArray()
        {
            int[] number = new int[10000];
            int sum = 0;
            Console.WriteLine("Please Input Array Size");
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {

                number[i] = Convert.ToInt32(Console.ReadLine());
                sum += number[i];
            }
            Console.WriteLine(sum);
        }



    }
}

