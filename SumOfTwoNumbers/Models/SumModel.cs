using System;
using System.ComponentModel.DataAnnotations;

namespace SumOfNumbers.Models
{
    public class SumModel
    {
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int FirstNumber { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        public int SecondNumber { get; set; }
        public int Result { get; set; }
    }
}