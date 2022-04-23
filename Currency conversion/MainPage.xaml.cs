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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Currency_conversion
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void LeftSwap_Click(object sender, RoutedEventArgs e)
        {
            VM.SwapLeft(true); 
            Frame.Navigate(typeof(SwapType), VM.GetSwapViewModel());

        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter != null)
            {
                VM.SetSwapViewModel((SwapViewModel) e.Parameter);
            }
            else
            {
                VM.init();
            }
        }

        private void RightSwap_Click(object sender, RoutedEventArgs e)
        {
            VM.SwapLeft(false);
            Frame.Navigate(typeof(SwapType), VM.GetSwapViewModel());
        }
    }
}
