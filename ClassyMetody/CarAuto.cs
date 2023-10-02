using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassyMetody
{
    internal class CarAuto
    {
        private string number;
        private float fuel;
        private float flow;

        public void info(string number, float fuel, float flow)
        {
            this.number = number;
            this.fuel = fuel;
            this.flow = flow;
        }
        public void outinfo()
        {
            Console.WriteLine($"Номер: {this.number}\n Топливо: {this.fuel}\n Расход: {this.flow}");
        }

        public void zaprawka(float top)
        {
            this.fuel += top;
        }
        public void move(int km)
        {
            
            Console.WriteLine($"осталось после поездки {this.fuel-(km*(this.flow)/100)} литров");
        }
    }
}
