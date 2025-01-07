using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Intro
{
    public class Test
    {
        public string Describe(object someObject)
        {
            if(someObject is int)
            {
                return $"Int of value {someObject}";
            }
            else if(someObject is decimal)
            {
                return $"Decimal of value {someObject}";
            } 
            else if (someObject is double)
            {
                return $"Double of value {someObject}";
            }
            
            return null;

        }
    }
}