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
        public SwapType()
        {
            this.InitializeComponent();
            
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                try
                {
                    VM.FillMe((SwapViewModel)e.Parameter);
                    foreach (var swapType in VM.GetId())
                    {
                        Button messageButton = new Button();
                        messageButton.Content = swapType;
                        messageButton.Width = 120;
                        messageButton.Height = 40;
                        messageButton.Background = new Windows.UI.Xaml.Media.SolidColorBrush(Windows.UI.Colors.Gray);
                        messageButton.Click += this.Click;
                        MyStack.Children.Add(messageButton);
                    }
                }catch (Exception)
                {

                }

            }
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button messageButton = (Button)sender;
            var a = messageButton.Content.ToString();
            if (VM.IsLeft)
            {
                VM.Type1 = a;
                VM.IsLeft = false;
            } else if (VM.IsRight)
            {
                VM.Type2 = a;
                VM.IsRight = false;
            }
            Frame.Navigate(typeof(MainPage), VM);
        }
    }
}
