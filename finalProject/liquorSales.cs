using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalProject
{
    abstract class liquorSales
    {
        private string _name;
        private double _price;
        private string _year;
       
        public liquorSales(string name, double price, string year)
        {
            _name = name;
            _price = price;
            _year = year;
        }


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public string Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public abstract string liquorSelect
        {
            get;
        }
        public override string ToString()
        {
            return  "Name:" +_name + ", Price $:" + _price+ ", Kind:" + _year;
        }
    }
}
