using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_4_2_
{
    /// <summary>
    /// Класс описывающмий учительский пропуск
    /// </summary>
    class TeacherPass : Pass, IValidatorPass
    {
        /// <summary>
        /// Свойство кафедры
        /// </summary>
        public string Department { get; set; }
        public TeacherPass() { }
        public TeacherPass(string firstName, string lastName, string patronymic, string faculty, string department) : base(firstName, lastName, patronymic, faculty)
        {
            Department = department;
        }

        /// <summary>
        /// метод проверки статуса пропуска
        /// </summary>
        /// <param name="currentDate">Дата</param>
        /// <returns>Всегда true</returns>
        public bool ValidatePass(DateTime currentDate)
        {
            return true;
        }
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        public override void Info()
        {
            Console.WriteLine($"Преподаватель: {FirstName} {LastName} {Patronymic}, Факультет: {Faculty}, Кафедра: {Department}");
        }
    }
}
