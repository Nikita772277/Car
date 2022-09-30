using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Vehicle
    {
        private string _model;//модель
        private string _stamp;//марка
        private decimal _price;//цена
        private int _enginepower; //мощность двигателя
        private int _fuelconsumption;//расход топлива в час
        private int _maximumspeed;//максимальная скорость
        private int _gasolinelevel;//уровень бензина
        public Vehicle()
        {

        }
        public void SetInformation()
        {
            Console.WriteLine($"Введите модель");
            _model = Console.ReadLine();
            Console.WriteLine($"Введите марку");
            _stamp = Console.ReadLine();
            Console.WriteLine($"Введите цену");
            string price = Console.ReadLine();
            _price = decimal.Parse(price);
            Console.WriteLine($"Введите мощьность двигателя");
            string enginepower = Console.ReadLine();
            _enginepower = int.Parse(enginepower);
            Console.WriteLine($"Расход топлива в час");
            string fuelconsumption = Console.ReadLine();
            _fuelconsumption = int.Parse(fuelconsumption);
            Console.WriteLine($"Максимальная скорость");
            string maximumspeed = Console.ReadLine();
            _maximumspeed = int.Parse(maximumspeed);
            Console.WriteLine($"Уровень бензина");
            string gasolinelevel = Console.ReadLine();
            _gasolinelevel = int.Parse(gasolinelevel);
        }
        public void ToStart()
        {
            Console.WriteLine("машина заведена");
            
        }
        public void GetInformation()
        {
            Console.WriteLine($"Модель: {_model}");
            Console.WriteLine($"Марка: {_stamp}");
            Console.WriteLine($"Цена: {_price}");
            Console.WriteLine($"Мощность двигателя: {_enginepower}");
            Console.WriteLine($"Расход топлива в час: {_fuelconsumption}");
            Console.WriteLine($"Максимальная скорость: {_maximumspeed}");
            Console.WriteLine($"Уровень бензина: {_gasolinelevel}");
        }
       public void Upgrade()
       {
                 _enginepower = _enginepower + 10; 
                _fuelconsumption = _fuelconsumption +5;
                _maximumspeed = _maximumspeed+20;
       }
    }
}
