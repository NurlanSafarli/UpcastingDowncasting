using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingTask.Models
{
    internal class Apple:Fruit
    {
        public double VitaminA { get; set; }
        public double VitaminB { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Alma turs ve sirin ola bilir.");
        }

    }
}
