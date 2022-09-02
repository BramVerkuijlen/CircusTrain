using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrain
{
    internal class Train
    {
        public List<Wagon> WagonList { get; set; }

        public Train(List<Wagon> wagons)
        {
            WagonList = wagons;
        }

        public void AddWagon(Wagon wagon)
        {
            WagonList.Add(wagon);
        }
    }
}
