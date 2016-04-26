using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class Whisky : liquorSales
    {
        private string _liquorType;
        private string _location;
        private string _liquorName = "Single Malt";
        public Whisky(string name, double price, string year, string liquorType, string location)
                                      : base (name,price, year)
        {
            _liquorType= liquorType;
            _location = location;

        }
        public string LiquorType
        {
            get { return _liquorType; }
            set { _liquorType = value; }
        }
        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public override string liquorSelect
        {
            get { return _liquorName; }
        }
        public override string ToString()
        {
            return base.ToString() + ",Type:" + _liquorName+ " ,Age:" + _liquorType +": Location: " + _location ;
        }

    }
}
