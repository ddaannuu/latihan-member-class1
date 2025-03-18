using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    internal class PlaneTicket
    {
        private string _origin;
        private string _destination;
        private int _cost;
        private string _currency;

        public string Origin
        {
            get { return _origin; }
            set { _origin = value; }
        }

        public string Destination
        {
            get { return _destination; }
            set { _destination = value; }
        }

        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public string Currency
        {
            get { return _currency; }
            set { _currency = value; }
        }

        public void PrintSummary()
        {
            Console.WriteLine($"Origin : {Origin}");
            Console.WriteLine($"Destination : {Destination}");
            Console.WriteLine($"Cost : {Cost} ({Currency})");
            if(Currency != null)
            {
                if(Currency == "USD")
                {
                    Console.WriteLine("Convert to Rupiah : " + _cost * 15000);
                }
                else if(Currency == "IDR")
                {
                    Console.WriteLine("Convert to Dolar : " + _cost / 15000);
                }
            }
            else
            {
                Console.WriteLine("Currency salah");

            }
        }
    }

}
