﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Student : Human
{
    private string facNumber;

    public Student(string firstName,string lastName,string facNumber)
        : base(firstName, lastName)
    {
        this.FacNumber = facNumber;
    }

    public string FacNumber
    {
        get
        {
            return this.facNumber;
        }
        set
        {
            if ((value.Length<5 || value.Length>10) || value.Any(c => !char.IsLetterOrDigit(c)))
            {
                throw new ArgumentException("Invalid faculty number!");
            }

            this.facNumber = value;
        }
    }
}
