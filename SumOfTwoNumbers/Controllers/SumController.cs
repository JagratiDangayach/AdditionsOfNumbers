using System;
using Microsoft.AspNetCore.Mvc;
using SumOfNumbers.BusinessLogic;
using SumOfNumbers.Models;

namespace SumOfNumbers.Controllers
{
    public class SumController : Controller
    {
        private readonly IAddNumbersLogic _addNumbers;

        /// <summary>
        /// Instantiates new instance of controller
        /// </summary>
        /// <param name="addNumberslogic"> Logic class for this controller</param>
        public SumController(IAddNumbersLogic addNumberslogic)
        {
            _addNumbers = addNumberslogic;
        }
        /// <summary>
        /// Method to get the view
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            SumModel model = new SumModel();
            return View(model);
        }
        /// <summary>
        /// Addition of two Numbers 
        /// </summary>
        /// <param name="sum"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(SumModel sum)
        {
            if (ModelState.IsValid)
            {
                sum.Result = _addNumbers.AddNumbers(sum);
                return View(sum);
            }
            else
            {
                return View(sum);
            }
        }
    }
}