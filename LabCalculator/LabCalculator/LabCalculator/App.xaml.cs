using LabCalculator.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LabCalculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Calculadora();
            MainPage = new Calculadora();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
