using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class Train
    {
        private List<Wagon> _wagonList = new List<Wagon>();
        public IReadOnlyCollection <Wagon> Wagons
        {
            get { return _wagonList.AsReadOnly(); }
        }
        
        public void AddWagonList(List<Wagon> Wagon)
        {
            foreach (Wagon wagon in Wagon)
                _wagonList.Add(wagon);
        }
    }
}
