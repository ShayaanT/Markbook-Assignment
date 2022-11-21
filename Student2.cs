using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Markbook_Ass
{
    
    class Student2 
    {
        public static string namefind;


        public void student2()
        {
            Console.Write("Please enter the name of the student profile you are looking for: ");
            namefind = Convert.ToString(Console.ReadLine());
            
        }
    }
}
