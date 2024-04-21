using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_4
{
    /// <summary>
    /// Класс описывающий туристическую фирму
    /// </summary>
     class Touristfirm : IComparable<Touristfirm>
    {
        /// <summary>
        /// Поля описывающию фирму
        /// </summary>
        private string name;
        private int yearofcreation;
        private string inn;
        private double profit;
        /// <summary>
        /// Свойства описывабщие фирму
        /// </summary>
        public string Name { get => name; set => name = value; }
        public int Yearofcreation { get => yearofcreation; set => yearofcreation = value; }
        public string Inn { get => inn; set => inn = value; }
        public double Profit { get => profit; set => profit = value; }
        /// <summary>
        /// Пустой конструктор
        /// </summary>
        public Touristfirm() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="yearofcreation">Год создания</param>
        /// <param name="inn">ИНН</param>
        /// <param name="profit">Прибыль за текущий год</param>
        public Touristfirm(string name, int yearofcreation, string inn, double profit)
        {
            Name = name;
            Yearofcreation = yearofcreation;
            Inn = inn;
            Profit = profit;
        }
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        public void Info()
        {
            Console.WriteLine($"Название: {Name};Год создания: {Yearofcreation};ИНН: {Inn};Прибыль за текущий год: {Profit};");
        }

        public int CompareTo(Touristfirm obj)
        {
           return Profit.CompareTo(obj.Profit);
        }
    }
}
