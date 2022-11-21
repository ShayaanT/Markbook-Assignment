using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Markbook_Ass
{
    class Student1
    {
        public static string[] name;
        public string name1;
        public int grade1;
        public static int age1;
        public static int amount1;
        public string[] subjects1;
        public double[] scores1;
        public static double score1total;
        public static string subject1;
        public static int score1;
        public double score1avg;


        public void profile()

        {
            
            
            Console.Write("Name: ");
            name1 = Convert.ToString(Console.ReadLine());
            
        
            Console.Write("Grade: ");
            grade1 = Convert.ToInt32(Console.ReadLine());
        

            Console.Write("Age: ");
            age1 = Convert.ToInt32(Console.ReadLine());

            if (grade1 == 9 || grade1 == 10 || grade1 == 11)
            {
                Console.WriteLine("You are required to take 4 courses.");
                subjects1 = new string[4];
                scores1 = new double[4];
                score1total = 0;

                for (int x = 0; x < 4; x++)
                {
                    Console.Write("Subject name: ");
                    subject1 = Convert.ToString(Console.ReadLine());
                    Console.Write("corresponding score: ");
                    score1 = Convert.ToInt32(Console.ReadLine());

                    subjects1[x] = subject1;
                    scores1[x] = score1;
                    score1total = score1total + scores1[x];
                    Console.WriteLine();
                }
                score1avg = score1total / 4;
                
                

                Console.WriteLine("Student Added Successfully");

                Console.WriteLine();
                Console.WriteLine("Student name: " + name1);
                Console.WriteLine("Student grade: " + grade1);
                for (int y = 0; y < subjects1.Length; y++)
                {
                    Console.WriteLine("Subject " + (y + 1) + ": " + subjects1[y] + " - " + scores1[y]);
                }
                Console.WriteLine(name1 + "'s total average is " + score1avg);
                Console.ReadLine();
        
            }
            if (grade1 == 12)
            {
                Console.WriteLine("You can take up to 4 courses. How many would you like?");
                amount1 = Convert.ToInt32(Console.ReadLine());

                subjects1 = new string[amount1];
                scores1 = new double[amount1];
                score1total = 0;

                for (int x = 0; x < amount1; x++)
                {
                    Console.Write("Subject name: ");
                    subject1 = Convert.ToString(Console.ReadLine());
                    Console.Write("corresponding score: ");
                    score1 = Convert.ToInt32(Console.ReadLine());

                    subjects1[x] = subject1;
                    scores1[x] = score1;
                    score1total = score1total + scores1[x];
                    Console.WriteLine();
                }
                score1avg = score1total / amount1;

                Console.WriteLine("Student Added Successfully");
                Console.WriteLine();
                Console.WriteLine("Student name: " + name1);
                Console.WriteLine("Student grade: " + grade1);

                for (int y = 0; y < subjects1.Length; y++)
                {
                    Console.WriteLine("Subject " + (y + 1) + ": " + subjects1[y] + " - " + scores1[y]);
                }
                Console.WriteLine(name1 + "'s total average is " + score1avg);
                Console.ReadLine();
            }
            
        
        
        
        
         
        
    }
    }
}
