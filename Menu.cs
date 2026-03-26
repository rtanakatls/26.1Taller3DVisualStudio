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
            E1();
        }

        private void Example()
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

        private void E1()
        {
            int b;
            int h;
            b = GetPositiveInt("Introduce la base");
            h = GetPositiveInt("Introduce la altura");
            Console.WriteLine($"El perímetro es {2 * b + 2 * h} y el área es {b * h}");
        }

        private int GetPositiveInt(string message)
        {
            int value = -1;
            while(value<=0)
            {
                Console.WriteLine(message);
                value= int.Parse(Console.ReadLine());
                if(value<=0)
                {
                    Console.WriteLine("El valor debe ser positivo");
                }
            }
            return value;
        }

        private int GetAge()
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
