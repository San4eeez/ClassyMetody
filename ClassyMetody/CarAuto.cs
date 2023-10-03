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
        private float speed;

        public void info(string number, float fuel, float flow)
        {
            this.number = number;
            this.fuel = fuel;
            this.flow = flow;
        }
        public void outinfo()
        {
            Console.WriteLine($"Номер: {this.number}\nТопливо: {this.fuel} Расход: {this.flow}");
        }

        private void zaprawka(float top)
        {
            this.fuel += top;
        }

        public void speedoz (float speed)
        {

        }
        public void move(int km)
        {

            float ostatok = this.fuel - (km * (this.flow) / 100);
            if (ostatok > 0)
            {
                Console.WriteLine("Осталось в баке: " + ostatok + " л");
                Console.WriteLine("Ты доехал!");
            }
            if (ostatok < 0)
            {
                Console.WriteLine("А ты хрен доедешь, давай зальём?");
                zaprawka(float.Parse(Console.ReadLine()));
                ostatok = this.fuel - (km * (this.flow) / 100);
                
                if (ostatok > 0)
                {
                   

                    Console.WriteLine("Мы смогли доехать до рая и в баке осталось: " + ostatok);
                    Console.WriteLine($"Наш путь до кабинета 1.11: {km} км) (ДАЛЬШЕ БОГА НЕТ)");
                }
                if (ostatok < 0)
                {
                    float for_ostatok = (ostatok * -1);
                    Console.WriteLine($"Наш путь до кабинета 1.11: {km} км) (ДАЛЬШЕ БОГА НЕТ)");

                    Console.WriteLine($"Вам не хватило топлива до рая. Нужно было залить ещё {for_ostatok:F1} литра(ов)");
                }
            }


        }
    }
}
