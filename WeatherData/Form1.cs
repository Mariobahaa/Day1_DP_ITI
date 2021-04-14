using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherData
{
    public class TextArgs: EventArgs
    {
        public string cc;
        public string fc;
        public string hi;
    }
    public partial class Form1 : Form
    {
        public WeatherData weatherData;
        public CurrentConditionsDisplay CurrentConditionsDisplay;
        public ForecastDisplay ForecastDisplay;
        public HeatIndexDisplay HeatIndexDisplay;

        public event EventHandler<TextArgs> Changed;

        public Form1()
        {
            InitializeComponent();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            weatherData = new WeatherData();
            CurrentConditionsDisplay = new CurrentConditionsDisplay(weatherData);
            ForecastDisplay = new ForecastDisplay(weatherData);
            HeatIndexDisplay = new HeatIndexDisplay(weatherData);
            label4.Text = CurrentConditionsDisplay.Display();
            label5.Text = ForecastDisplay.Display();
            label6.Text = HeatIndexDisplay.Display();

            Form2 form2 = new Form2();
            form2.Show();
            Changed += form2.Update;

            Form3 form3 = new Form3();
            form3.Show();
            Changed += form3.Update;

            Form4 form4 = new Form4();
            form4.Show();
            Changed += form4.Update;
            //Subscribe
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            weatherData.SetMeasurements(SBTemperature.Value, SBHumidity.Value, SBPressure.Value);
            label4.Text = CurrentConditionsDisplay.Display();
            label5.Text = ForecastDisplay.Display();
            label6.Text = HeatIndexDisplay.Display();
            Changed.Invoke(this, new TextArgs() { cc = label4.Text,
                fc = label5.Text, hi = label6.Text }) ;

        }
    }
}
