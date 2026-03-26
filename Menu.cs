using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D261
{
    internal class Menu
    {
        public void Execute()
        {
            string name;
            int age;

            Console.WriteLine("Introduce tu nombre:");
            name = Console.ReadLine();
            Console.WriteLine($"Hola {name}");
            age = GetAge();
            Console.WriteLine($"Tienes {age} años.");
            Console.WriteLine($"El próximo año tendrás {age + 1}");
                
        }

        public int GetAge()
        {
            bool isValid = false;
            int age = 0;
            while (!isValid)
            {
                Console.WriteLine("Introduce tu edad:");
                age = int.Parse(Console.ReadLine());
                if (age >= 0)
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("La edad no puede ser negativa");
                }
            }
            return age;
        }
    }
}
