using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_4_2_
{
    /// <summary>
    /// Интрерфейс проверки проверки срока пропуска
    /// </summary>
    interface IValidatorPass
    {
        /// <summary>
        /// Метод проверки пропусков
        /// </summary>
        /// <param name="currentDate">Текущий год</param>
        /// <returns></returns>
        bool ValidatePass(DateTime currentDate);
    }
}
