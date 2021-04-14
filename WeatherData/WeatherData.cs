using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherData
{

    public class WeatherData
    {
        public event EventHandler DataChanged;

        private float _temperature;
        private float _humidity;
        private float _pressure;


    }
}
