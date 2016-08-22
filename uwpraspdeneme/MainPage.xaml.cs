using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Gpio;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace uwpraspdeneme
{

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public GpioController gpio;
        public GpioPin redpin;
        public GpioPin yellowpin;
        public GpioPin greenpin;

        public MainPage()
        {
            InitializeComponent();
            InitGPIO();
            this.InitializeComponent();
        }
        private void InitGPIO()
        {
            gpio = GpioController.GetDefault();
            if (gpio == null)
                return;

            redpin = gpio.OpenPin(5);
            yellowpin = gpio.OpenPin(4);
            greenpin = gpio.OpenPin(6);
        }

        private void turnOffAllLED()
        {
            redpin.Write(GpioPinValue.Low);
            redpin.SetDriveMode(GpioPinDriveMode.Output);

            yellowpin.Write(GpioPinValue.Low);
            yellowpin.SetDriveMode(GpioPinDriveMode.Output);

            greenpin.Write(GpioPinValue.Low);
            greenpin.SetDriveMode(GpioPinDriveMode.Output);

        }







        public async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            RootObject myweather = await OpenWeahterMapProxy.GetWeather(20.0, 30.0);
            string icon = string.Format("ms-appx:///Assets/Weather/{0}.png", myweather.weather[0].icon);
            ResultImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
            var x = myweather.main.temp;

            int sıcaklık = Convert.ToInt32(x);
            sıcaklık = sıcaklık - 273;
            if (myweather.weather[0].description == "clear sky")
            {
                turnOffAllLED();
                yellowpin.Write(GpioPinValue.High);
                greenpin.Write(GpioPinValue.Low);
                redpin.Write(GpioPinValue.High);
            }
            else
            {
                turnOffAllLED();
                yellowpin.Write(GpioPinValue.Low);
                greenpin.Write(GpioPinValue.High);
                redpin.Write(GpioPinValue.High); ;
            }

            Sonuç.Text =  myweather.name + "   " + sıcaklık + "\n" + myweather.weather[0].description;
        }




        private void image1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            turnOffAllLED();
            yellowpin.Write(GpioPinValue.Low);
            greenpin.Write(GpioPinValue.High);
            redpin.Write(GpioPinValue.Low); ;
            Task.Delay(1000).Wait();
        }

        private void image2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            turnOffAllLED();
            yellowpin.Write(GpioPinValue.Low);
            greenpin.Write(GpioPinValue.Low);
            redpin.Write(GpioPinValue.High);
            Task.Delay(1000).Wait();
        }

        private void image3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            turnOffAllLED();
            yellowpin.Write(GpioPinValue.High);
            greenpin.Write(GpioPinValue.High);
            redpin.Write(GpioPinValue.High);
            Task.Delay(1000).Wait();
        }

        private void image4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            turnOffAllLED();
            yellowpin.Write(GpioPinValue.Low);
            greenpin.Write(GpioPinValue.High);
            redpin.Write(GpioPinValue.High);
            Task.Delay(1000).Wait();
        }

        private void image5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            yellowpin.Write(GpioPinValue.Low);
            greenpin.Write(GpioPinValue.Low);
            redpin.Write(GpioPinValue.High);
            Task.Delay(1000).Wait();
        }

        private void image6_Tapped(object sender, TappedRoutedEventArgs e)
        {
            yellowpin.Write(GpioPinValue.Low);
            greenpin.Write(GpioPinValue.High);
            redpin.Write(GpioPinValue.Low);
            Task.Delay(1000).Wait();
        }

        private void image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(RGB));
        }
    }
}
