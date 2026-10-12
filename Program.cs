using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{

    class ApplicationException:Exception
    {
        public ApplicationException(string msg):base(msg)
        {
            
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            //Palindrome or not
            //string str = "malayalam";
            //string rev = "";
            //for(int i=(str.Length)-1;i>=0;i--)
            //{
            //    rev += str[i];
            //}
            //if(str==rev)
            //{
            //    Console.WriteLine("Palinfdrome string");
            //}
            //else
            //{
            //    Console.WriteLine("Not Palindrome");
            //}

            try
            {
                Console.WriteLine("Enter the Age");
                int Age = int.Parse(Console.ReadLine());
                if(Age<18)
                {
                    throw new ApplicationException("Age Less than not Applicable ");
                }
            }
            catch(ApplicationException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
