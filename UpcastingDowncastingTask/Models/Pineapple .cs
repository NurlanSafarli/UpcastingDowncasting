﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingTask.Models
{
    internal class Pineapple:Fruit
    {
        public double VitaminE { get; set; }
        public double VitaminD { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Ananas turs ve sirin ola bilir");
        }



    }
}
