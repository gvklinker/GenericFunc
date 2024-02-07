using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunc
{
    public class Car
    {
        public int Id { get; set; }
        public string Regno { get; set; }
        public string Make { get; set; }

        public int Speed { get; set; }

        private int _counter = 0;

        public Car(string regno, string make, int speed)
        {
            Id = _counter++;
            Regno = regno;
            Make = make;
            Speed = speed;

        }

        public override string ToString()
        {
            return $"{{{nameof(Id)}={Id.ToString()}, {nameof(Regno)}={Regno}, {nameof(Make)}={Make}, {nameof(Speed)}={Speed.ToString()}}}";
        }

    }

}
