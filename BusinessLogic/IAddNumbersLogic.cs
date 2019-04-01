using SumOfNumbers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SumOfNumbers.BusinessLogic
{
    /// <summary>
    /// This interface is used to get sum of the two numbers
    /// </summary>
    public interface IAddNumbersLogic 
    {
         int AddNumbers(SumModel model);
    }
}
