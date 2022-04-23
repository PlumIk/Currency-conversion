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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Currency_conversion
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SwapType : Page
    {
        List<string> swapTypes = new List<string>()
        {
            "one", "Two","one more"
        };
        public SwapType()
        {
            this.InitializeComponent();
            foreach (var swapType in swapTypes)
            {
                Button messageButton = new Button();
                messageButton.Content = swapType;
                messageButton.Width = 120;
                messageButton.Height = 40;
                messageButton.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Gray);
                messageButton.Click += this.Click;
                MyStack.Children.Add(messageButton);
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                var one = (MainViewModel)e.Parameter;
                VM.swapLeft = one.swapLeft;
                VM.swapRight = one.swapRight;
                string a = "Error";
                if (one.swapLeft)
                    a = "Left";
                else if (one.swapRight)
                    a = "Right";
                swapTypes.Add(a);
            }
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button messageButton = (Button)sender;
            var a = messageButton.Content;
            if (VM.swapLeft)
                VM.Type1 = sender.ToString();
            else if (VM.swapRight)
                VM.Type2 = sender.ToString();
            Frame.Navigate(typeof(MainPage), VM);
        }
    }
}
