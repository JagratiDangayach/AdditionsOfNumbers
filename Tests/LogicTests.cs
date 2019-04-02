using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfNumbers.BusinessLogic;
using SumOfNumbers.Controllers;
using SumOfNumbers.Models;

namespace Tests
{
    [TestClass]
    public class LogicTests
    {
        private readonly AddLogic _logic;

        public LogicTests()
        {
            _logic = new AddLogic();
        }
        [TestMethod]
        public void Add3And5Returns8()
        {
            //Arrange
            var model = new SumModel()
            {
                FirstNumber = 3,
                SecondNumber = 5
            };
            //Act
            int result = _logic.AddNumbers(model);
            //Assert
            Assert.AreEqual(8, result);
        }
       


    }  
}
