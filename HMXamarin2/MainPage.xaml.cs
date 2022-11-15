using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HMXamarin2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ClicBoton(object sender, EventArgs e)
        {
            txtEtiqueta.Text = "Adios"; 
        }
    }
}
