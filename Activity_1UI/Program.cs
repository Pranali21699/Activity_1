using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            string[] value = new string[] { "java", "cplusplus", "python", "Csharp", "C" };
            Instructor obj = new Instructor("Pranali", 4.6f, 4, value);
            Console.WriteLine(obj.CheckSkill("python"));


        }
    }
}
