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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public void Update(object sender, TextArgs eventArgs)
        {
            label1.Text = eventArgs.fc;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
