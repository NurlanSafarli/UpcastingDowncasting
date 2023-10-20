using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingTask.Models
{
    internal class Orange:Fruit
    {
        public double VitaminC { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Portagal turs ve sirin ola bilir");
        }


    }
}
