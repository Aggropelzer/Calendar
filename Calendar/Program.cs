﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = CommandLineParser.parseArguments(args);
            Year year = YearCreator.createYear(input);
        }
    }
}
