﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwinAdventure
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IdentifiableObject id = new IdentifiableObject(new string[] { "id1", "id2" });

            Console.WriteLine(id.AreYou("lura"));

          
        }
    }
}
