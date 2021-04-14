using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherData
{
    public class WeatherDataArgs : EventArgs
    {
        public float temperature;
        public float humidity;
        public float pressure;
    }
    public class WeatherData
    {
        public WeatherData() { _temperature = _humidity = _temperature = 0; }

        public event EventHandler<WeatherDataArgs> DataChanged;

        private float _temperature;
        private float _humidity;
        private float _pressure;

        public void MeasurementsChanged()
        {
            DataChanged.Invoke(this, new WeatherDataArgs()
            {
                temperature = _temperature,
                humidity = _humidity,
                pressure = _pressure
            });
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this._temperature = temperature;
            this._humidity = humidity;
            this._pressure = pressure;
            MeasurementsChanged();
        }


    }


    public class CurrentConditionsDisplay
    {
        private float _temperature;
        private float _humidity;
        private WeatherData _weatherData;

        public CurrentConditionsDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            weatherData.DataChanged += this.Update;
        }

        public void Update(Object sender, WeatherDataArgs eventArgs)
        {
            this._temperature = eventArgs.temperature;
            this._humidity = eventArgs.humidity;
            Display();
        }

        public string Display()
        {
            return "Current conditions: " + _temperature
                + "F degrees and " + _humidity + "% humidity";
        }
    }

    public class ForecastDisplay
    {
        private float _currentPressure = 29.92f;
        private float _lastPressure;
        private WeatherData _weatherData;

        public ForecastDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            weatherData.DataChanged += this.Update;

        }

        public void Update(Object sender, WeatherDataArgs eventArgs)
        {
            _lastPressure = _currentPressure;
            _currentPressure = eventArgs.pressure;

            Display();
        }

        public string Display()
        {
            string forecast = "Forecast \n";

            if (_currentPressure > _lastPressure)
            {
                forecast += "Improving weather on the way!";
            }
            else if (_currentPressure == _lastPressure)
            {
                forecast += "More of the same";
            }
            else if (_currentPressure < _lastPressure)
            {
                forecast += "Watch out for cooler, rainy weather";
            }
            return forecast;
        }
    }

    public class HeatIndexDisplay 
    {
        private float _heatIndex = 0.0f;
        private WeatherData _weatherData;

        public HeatIndexDisplay(WeatherData weatherData)
        {
            this._weatherData = weatherData;
            weatherData.DataChanged += this.Update;

        }

        public void Update(Object sender, WeatherDataArgs eventArgs)
        {
            _heatIndex = ComputeHeatIndex(eventArgs.temperature, eventArgs.humidity);
            Display();
        }

        private float ComputeHeatIndex(float t, float rh)
        {
            float heatindex = (float)
                    (
                    (16.923 + (0.185212 * t)) +
                    (5.37941 * rh) -
                    (0.100254 * t * rh) +
                    (0.00941695 * (t * t)) +
                    (0.00728898 * (rh * rh)) +
                    (0.000345372 * (t * t * rh)) -
                    (0.000814971 * (t * rh * rh)) +
                    (0.0000102102 * (t * t * rh * rh)) -
                    (0.000038646 * (t * t * t)) +
                    (0.0000291583 * (rh * rh * rh)) +
                    (0.00000142721 * (t * t * t * rh)) +
                    (0.000000197483 * (t * rh * rh * rh)) -
                    (0.0000000218429 * (t * t * t * rh * rh)) +
                    (0.000000000843296 * (t * t * rh * rh * rh)) -
                    (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return heatindex;
        }

        public string Display()
        {
            return "Heat index is " + _heatIndex + "\n";
        }
    }
}
