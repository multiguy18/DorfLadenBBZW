using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DorfladenBBZW.Formatters;

namespace DorfladenBBZW.TypeExtensions
{
    public static class StringExtensions
    {
        public static string EvalToDecimalFormat(this object evalResult)
        {
            decimal price = Convert.ToDecimal(evalResult);
            return price.AsChf();
        }
    }
}