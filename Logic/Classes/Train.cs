using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Train
    {
        private List<Wagon> _wagonList;
        public IEnumerable<Wagon> WagonList
        {
            get { return _wagonList; }
        }
        
        public void AddWagon(Wagon wagon)
        {
            _wagonList.Add(wagon);
        }


    }
}
