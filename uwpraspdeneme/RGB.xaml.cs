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
using Windows.UI.Xaml.Navigation;
using Windows.Devices.Gpio;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace uwpraspdeneme
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    
    public sealed partial class RGB : Page
    {

        public RGB()
        {
            InitializeComponent();

            this.InitializeComponent();
        }
        //private void InitGPIO()
        //{
        //    gpio = GpioController.GetDefault();
        //    //if (gpio == null)
        //    //    return;

        //    redpin = gpio.OpenPin(4);
        //    yellowpin = gpio.OpenPin(5);
        //    greenpin = gpio.OpenPin(6);
        //}
        //private void turnOffAllLED()
        //{
        //    redpin.Write(GpioPinValue.Low);
        //    redpin.SetDriveMode(GpioPinDriveMode.Output);

        //    yellowpin.Write(GpioPinValue.Low);
        //    yellowpin.SetDriveMode(GpioPinDriveMode.Output);

        //    greenpin.Write(GpioPinValue.Low);
        //    greenpin.SetDriveMode(GpioPinDriveMode.Output);

        //}


        private void image_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            //turnOffAllLED();
            //yellowpin.Write(GpioPinValue.High);
            //greenpin.Write(GpioPinValue.Low);
            //redpin.Write(GpioPinValue.Low);
        }

        private void button_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //turnOffAllLED();
            //yellowpin.Write(GpioPinValue.Low);
            //greenpin.Write(GpioPinValue.High);
            //redpin.Write(GpioPinValue.High);
        }

        private void button1_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //turnOffAllLED();
            //yellowpin.Write(GpioPinValue.High);
            //greenpin.Write(GpioPinValue.High);
            //redpin.Write(GpioPinValue.Low);
        }

        private void button4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //turnOffAllLED();
            //yellowpin.Write(GpioPinValue.High);
            //greenpin.Write(GpioPinValue.Low);
            //redpin.Write(GpioPinValue.Low);
        }

        private void button2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //turnOffAllLED();
            //yellowpin.Write(GpioPinValue.High);
            //greenpin.Write(GpioPinValue.Low);
            //redpin.Write(GpioPinValue.High);
        }

        private void button3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //yellowpin.Write(GpioPinValue.Low);
            //greenpin.Write(GpioPinValue.High);
            //redpin.Write(GpioPinValue.Low);
        }

        private void button5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //yellowpin.Write(GpioPinValue.Low);
            //greenpin.Write(GpioPinValue.Low);
            //redpin.Write(GpioPinValue.High);
        }
    }
}
