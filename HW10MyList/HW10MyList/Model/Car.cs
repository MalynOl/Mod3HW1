using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10MyList
{
    public class Car : IComparable
    {
        public Car(int id, string name)
        {
            CarID = id;
            CarName = name;
        }

        public int CarID { get; set; }

        public string CarName { get; set; }

        public int CompareTo(object obj)
        {
            Car temp = obj as Car;
            if (temp == null)
            {
                throw new ArgumentException("Parameter is not a Car!");
            }
            else
            {
                return CarID.CompareTo(temp.CarID);
            }
        }
    }
}
