using System;
using System.Collections.Generic;

namespace HW10MyList
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car(id: 10, name: "Audi");
            Car car2 = new Car(id: 2, name: "BMW");
            Car[] cars = { car, car2 };

            MyList<Car> myAutos = new MyList<Car>(cars);
            myAutos.Add(new Car(id: 4, name: "Ford"));
            myAutos.AddRange(new Car[] { new Car(id: 16, name: "Skoda"), new Car(id: 7, name: "Tesla") });
            bool res = myAutos.Remove(car2);
            myAutos.RemoveAt(3);

            foreach (var item in myAutos)
            {
                Console.WriteLine($"Auto {item.CarID.ToString()} name  {item.CarName.ToString()}");
            }

            myAutos.Sort();

            Console.WriteLine("Sort autos");
            foreach (var item in myAutos)
            {
                Console.WriteLine($"Auto {item.CarID.ToString()} name  {item.CarName.ToString()}");
            }
        }
    }
}
