using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    class GrocessaryItems
    {
        
       // private int _Id;
        private double _price;
        private string _name;
        private DateTime _dateTime;
        private string _location;

        public GrocessaryItems( string name, double price, DateTime dateTime, string location)
        {
            
            _name = name;
            _price = price;
            _dateTime = dateTime;
            _location = location;
        }
        //public int Id
        //{
        //    get { return _Id; }
        //    set { _Id = value; }
        //}
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double price
        {
            get { return _price; }
            set { _price = value; }
        }
        public DateTime dateTime
        {
            get { return _dateTime; }
            set { _dateTime = value; }
        }
        public string location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
