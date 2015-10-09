using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov2015
{
    public class SimpleParser
    {
        /*This is a class with functions that can 
          do various operations on strings.
        */
        
        /*Returns the sum of numbers separated with commas.*/
        public int ParseAndSum(string numbers) {
            if (numbers.Length == 0)
            {
                return 0;
            }
            if (!numbers.Contains(","))
            {
                return int.Parse(numbers);
            }
            else {
                //TODO: Research v.Split function.

                throw new InvalidOperationException("I can only handle 0 or 1 numbers for now!");
            }
        }

        /*Returns the product of numbers separated with commas.*/
        public int ParseAndMultiply(string numbers) {
            if (numbers.Length == 0)
            {
                return 0;
            }
            //TODO: Implement parsing and multiply the numbers. num1 * num2...
            return 0;
        }

        /*Parses a string into .*/
        public string[] ParseAndSplit(string v)
        {
            //HACK: Nothing usefull done here, but test runs at least.
            return null;
        }
    }
}
