using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Markbook_Ass
{
    class Program : Student1
    {
        static void Main(string[] args)
        {
            
            int classcount = 0;
            int num = 0;

            List<Student1> grade9101112profile = new List<Student1>();
            for (int x = 0; true; x++)
            {
                Menu(classcount, grade9101112profile, num);
            }
            
        }
        static void Menu(int classcount, List<Student1> grade9101112profile, int num)
        {
            
            Console.WriteLine("Welcome to the Class Markbook Program!");
            Console.WriteLine();
            Console.WriteLine("To add a student number 1");
            Console.WriteLine("To find a student, enter 2");
            Console.WriteLine("To delete a student, enter 3");
            Console.WriteLine("To exit, enter 4");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {



                if (grade9101112profile.Count <= 30)
                {

                    
                    Student1 student = new Student1();
                    student.profile();
                    grade9101112profile.Add(student);
                    Student1.name = new string[30];
                    Student1.name[grade9101112profile.Count - 1] = student.name1;
                    student.name1 = Student1.name[grade9101112profile.Count - 1];

                        
                    


                }
            }

            if (input == 2)
            {
                
                int find = 0;
                Student2 studenntfind = new Student2();
                studenntfind.student2();


                foreach (var student in grade9101112profile)
                {
                    if (student.name1 == Student2.namefind)
                    {
                        find = 1;
                        Console.WriteLine();
                        Console.WriteLine("Student found.");
                        Console.WriteLine();

                        if (student.grade1 == 9 || student.grade1 == 10 || student.grade1 == 11)
                        {
                            Console.WriteLine("Student name: " + student.name1);
                            Console.WriteLine("Student grade: " + student.grade1);
                            for (int y = 0; y < student.subjects1.Length; y++)
                            {
                                Console.WriteLine("Subject " + (y + 1) + ": " + student.subjects1[y] + " - " + student.scores1[y]);
                            }
                            Console.WriteLine(student.name1 + "'s total average is " + student.score1avg);
                            Console.WriteLine();
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                        }

                        if (student.grade1 == 12)
                        {
                            find = 1;
                            Console.WriteLine("Student name: " + student.name1);
                            Console.WriteLine("Student grade: " + student.grade1);
                            for (int y = 0; y < student.subjects1.Length; y++)
                            {
                                Console.WriteLine("Subject " + (y + 1) + ": " + student.subjects1[y] + " - " + student.scores1[y]);
                            }
                            Console.WriteLine(student.name1 + "'s total average is " + student.score1avg);
                            Console.WriteLine();
                            Console.WriteLine("Press Enter to continue");
                            Console.ReadLine();
                        }
                    }
                }

                    if (find == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine(Student2.namefind + "'s student profile could not be found. Press enter to return to the main menu");
                        Console.ReadLine();

                    }

                

            }

            if (input == 3)
            {
                int find = 0;
                Student2 studentdelete = new Student2();
                studentdelete.student2();

                foreach (var student in grade9101112profile)
                {
                    if (student.name1 == Student2.namefind)
                    {
                        find = 1;
                        Console.WriteLine();
                        Console.WriteLine("Student found.");
                        Console.WriteLine();

                        if (student.grade1 == 9 || student.grade1 == 10 || student.grade1 == 11)
                        {
                            Console.WriteLine("Student name: " + student.name1);
                            Console.WriteLine("Student grade: " + student.grade1);
                            for (int y = 0; y < student.subjects1.Length; y++)
                            {
                                Console.WriteLine("Subject " + (y + 1) + ": " + student.subjects1[y] + " - " + student.scores1[y]);
                            }
                            Console.WriteLine(student.name1 + "'s total average is " + student.score1avg);
                            Console.WriteLine();
                        }

                        if (student.grade1 == 12)
                        {
                            Console.WriteLine("Student name: " + student.name1);
                            Console.WriteLine("Student grade: " + student.grade1);
                            for (int y = 0; y < student.subjects1.Length; y++)
                            {
                                Console.WriteLine("Subject " + (y + 1) + ": " + student.subjects1[y] + " - " + student.scores1[y]);
                            }
                            Console.WriteLine(student.name1 + "'s total average is " + student.score1avg);
                            Console.WriteLine();
                        }

                        Console.Write("Confirm deletion of " + student.name1 + "'s profile? (yes/no): ");
                        string input2 = Convert.ToString(Console.ReadLine());

                        if (input2 == "yes")
                        {
                            int location = grade9101112profile.FindIndex(a => a.name1.Contains(Student2.namefind));
                            grade9101112profile.RemoveAt(location);
                            Console.WriteLine();
                            Console.WriteLine(student.name1 + "'s student profile has been removed from your class successfully, press enter to return to main menu");
                            Console.ReadLine();
                            break;
                        }
                        if (input2 == "no")
                        {
                            Console.WriteLine("Press enter to return back to the main menu");
                            Console.ReadLine();
                            break;
                        }
                    }
                }

                    if (find == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine(Student2.namefind + "'s student profile could not be found. Press enter to return to the main menu");
                        Console.ReadLine();
                       
                    }
                
            }

            if (input == 4)
            {
                var miliseconds = 1500;
                Console.WriteLine();
                Console.WriteLine("Thank You, have a great day");
                Thread.Sleep(miliseconds);///Do not press enter, as this is the code for a self exiting program
                Environment.Exit(0);
            }
            if (input > 4)
            {
                ////this will give an error message, as there is no category above the number 7, so you will have to try again
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("Invalid entry. Press enter to try again.");
                Console.ReadLine();
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }

        }
    }
}
