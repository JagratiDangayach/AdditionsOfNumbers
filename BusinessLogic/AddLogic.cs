using SumOfNumbers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumOfNumbers.BusinessLogic
{
    public class AddLogic : IAddNumbersLogic
    {
        /// <summary>
        /// Logic to add the numbers
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int AddNumbers(SumModel sum)
        {
            int res = sum.FirstNumber + sum.SecondNumber;
            return res;

        }
    }
}

