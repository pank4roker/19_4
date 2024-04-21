using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_4_2_
{
    /// <summary>
    /// Класс описывающмий студентечкий пропуск
    /// </summary>
    class StudentPass : Pass, IValidatorPass
    {
        /// <summary>
        /// Свойство года поступления
        /// </summary>
        public int YearOfAdmission { get; set; }
        public StudentPass() { }
        public StudentPass(string firstName, string lastName, string patronymic, string faculty, int yearOfAdmission) : base(firstName, lastName, patronymic, faculty)
        {
            YearOfAdmission = yearOfAdmission;
        }
        /// <summary>
        /// метод проверки статуса пропуска
        /// </summary>
        /// <param name="currentDate">Дата</param>
        /// <returns>Если студент учится менее 4 лет</returns>
        public bool ValidatePass(DateTime currentDate)
        {
            return (currentDate.Year - YearOfAdmission < 4); 
        }
        /// <summary>
        /// Метод вывода информации
        /// </summary>
        public override void Info()
        {
            Console.WriteLine($"Студент: {FirstName} {LastName} {Patronymic}, Факультет: {Faculty}, Год поступления: {YearOfAdmission}");
        }
    }
}
