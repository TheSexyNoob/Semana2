using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LAB02;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Person");
              //ILogger logger = new Persona();
    
              Persona persona = new Persona();
              persona.Id = 1;
              persona.Name = "Luis";
              persona.LastName = "Nunez";
            /*  
             * {
             * Id = 1,
             * Name = "Luis",
             * LastName = "Nunez"
             * };
             */

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
           }

            ILogger logger = p;
            String personString = string.Format("ID: {0}, Name: {1} and Last Name: {2}.", p.Id, p.Name, p.LastName);
            logger.Log(personString);
            
            Console.ReadKey();
        }
    }
}
