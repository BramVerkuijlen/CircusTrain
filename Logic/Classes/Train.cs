using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Train
    {
        public List<Wagon> WagonList { get; private set; }
        
        public void AddWagon(Wagon wagon)
        {
            WagonList.Add(wagon);
        }


    }
}
