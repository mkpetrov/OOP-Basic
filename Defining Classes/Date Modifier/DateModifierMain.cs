using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_Modifier
{
    class DateModifierMain
    {
        static void Main(string[] args)
        {
            var firstDate = Console.ReadLine();
            var secondDate = Console.ReadLine();

            var DateModifier = new DateModifier(firstDate, secondDate);

            DateModifier.GetDifferenceDays(firstDate, secondDate);
        }
    }
}
