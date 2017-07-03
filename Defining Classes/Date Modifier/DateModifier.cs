using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class DateModifier
{
    private string firstDate;
    private string secondDate;

    public DateModifier(string firstDate,string secondDate)
    {
        this.firstDate = firstDate;
        this.secondDate = secondDate;
    }

    

    public void GetDifferenceDays(string firstDate, string secondDate)
    {
        var firstDateParts = firstDate.Split(' ');
        var secondDateParts = secondDate.Split(' ');

        var d1 = new DateTime(int.Parse(firstDateParts[0]), int.Parse(firstDateParts[1]), int.Parse(firstDateParts[2]));
        var d2 = new DateTime(int.Parse(secondDateParts[0]), int.Parse(secondDateParts[1]), int.Parse(secondDateParts[2]));

        Console.WriteLine($"{Math.Abs((d1-d2).TotalDays)}");
    }
}
