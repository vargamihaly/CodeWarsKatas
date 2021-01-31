using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace CodeWarsKatas.katas
{

    /// <summary>
    /// Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number.
    /// Kata.CreatePhoneNumber(new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0}) // => returns "(123) 456-7890"
    /// </summary>
    public static class CreatePhoneNumber
    {
        public static string CreatePhoneNumberSolution(int[] numbers)
        {
            var number = $"({numbers[0]}{numbers[1]}{numbers[2]}) {numbers[3]}{numbers[4]}{numbers[5]}-{numbers[6]}{numbers[7]}{numbers[8]}{numbers[9]}";
            return number;
        }
    }
}
