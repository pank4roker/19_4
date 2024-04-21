using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_4_2_
{
    /// <summary>
    /// Абстрактный класс описывающий пропук
    /// </summary>
    public abstract class Pass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Faculty { get; set; }
        public Pass() { }
        public Pass(string firstName, string lastName, string patronymic, string faculty)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Faculty = faculty;
        }
        /// <summary>
        /// Абстрактный метод вывода информации
        /// </summary>
        public abstract void Info();
    }

}
