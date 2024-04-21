using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_4_2_
{
    /// <summary>
    /// Класс описывающмий строительный пропуск
    /// </summary>
    class BuilderPass : Pass, IValidatorPass
    {
        /// <summary>
        /// Свойста начала и конца работ
        /// </summary>
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BuilderPass() { }
        public BuilderPass(string firstName, string lastName, string patronymic, string faculty, DateTime startDate, DateTime endDate) : base(firstName, lastName, patronymic, faculty)
        {
            StartDate = startDate;
            EndDate = endDate;
        }
        /// <summary>
        /// метод проверки статуса пропуска
        /// </summary>
        /// <param name="currentDate">Дата</param>
        /// <returns>Если текущая дата меньше или равна дате окончания работ</returns>
        public bool ValidatePass(DateTime currentDate)
        {
            return currentDate <= EndDate;
        }
        /// <summary>
        /// Метод вывода информации
        /// </summary>
         public override void Info()
         { 
        Console.WriteLine($"Строитель: {FirstName} {LastName} {Patronymic}, Факультет: {Faculty}, Дата начала работ: {StartDate.ToShortDateString()}, Дата окончания работ: {EndDate.ToShortDateString()}");
         }
}
}
