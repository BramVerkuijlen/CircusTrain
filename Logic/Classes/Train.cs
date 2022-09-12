using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class Train
    {
        private List<Wagon>? _wagonList = new List<Wagon>();
        public IEnumerable<Wagon> Wagons
        {
            get { return _wagonList; }
        }
        
        public void AddWagon(Wagon wagon)
        {
            _wagonList.Add(wagon);
        }

        public override string ToString()
        {
            string result = "rain";
            foreach (Wagon wagon in _wagonList)
            {
                result += ("\n" + wagon.ToString());
            }
            return result;
        }
    }
}
