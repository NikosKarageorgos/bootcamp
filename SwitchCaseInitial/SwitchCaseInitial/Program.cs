﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCaseInitial
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = "Greece";

            switch (country)
            {
                case "Russia":
                    Console.WriteLine("The country is Russia");
                    break;
                case "Greece":
                    Console.WriteLine("The country is Greece");
                    break;
                default:
                    Console.WriteLine("Uknown country");
                    break;
            }

            Console.ReadKey();
        }
    }
}
