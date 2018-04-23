using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb1_git
{
    class Address
    {
        /// <summary>
        /// Атрибуты класса.
        /// </summary>
        private string city;
        private string street;
        private int number;

        /// <summary>
        /// Блоки get, где мы возвращаем значение, и set, где мы устанавливаем значение, с использование модификаторов доступа.
        /// </summary>
        public string City
        {
            get
            {
                return city;
            }

            private set
            {
                city = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }

            private set
            {
                city = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            private set
            {
                number = value;
            }
        }

        public Address(string city, string street, int number)
        {
            this.City   = city;
            this.Street = street;
            this.Number = number;
        }

        /// <summary>
        /// Метод для ввода с клавиатуры.
        /// </summary>
        public void input()
        {
            Console.WriteLine("Введите адрес: ");
            Console.Write("Город: ");
            city = Console.ReadLine();
            Console.Write("Улица: ");
            street = Console.ReadLine();
            Console.Write("Номер: ");
            number = Convert.ToInt32(Console.ReadLine());
        }

        /// <summary>
        /// Метод для вывода на экран.
        /// </summary>
        public void print()
        {
            Console.WriteLine("Введённый адрес: ");
            Console.Write("Город: ");
            Console.WriteLine(city);
            Console.Write("Улица: ");
            Console.WriteLine("улица " + street);
            Console.Write("Номер: ");
            Console.WriteLine("номер " + number);
        }

    }
}
