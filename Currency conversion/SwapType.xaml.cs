using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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
                    foreach (var swapType in VM.GetShortName())
                    {
                        Button messageButton = new Button();
                        messageButton.Content = VM._customConvector._names[swapType];
                        messageButton.Tag = swapType;
                        messageButton.Margin = new Thickness(3, 3, 3, 3);
                        messageButton.VerticalAlignment = VerticalAlignment.Center;
                        messageButton.HorizontalAlignment = HorizontalAlignment.Center;
                        if ((VM.IsLeft && swapType == VM.Type1)||(VM.IsRight && swapType == VM.Type2))
                            messageButton.Background = new SolidColorBrush(Windows.UI.Colors.Gray);
                        else 
                            messageButton.Background = new SolidColorBrush(Windows.UI.Colors.DarkGray);
                        
                        messageButton.Click += this.Click;
                        MyStack.Children.Add(messageButton);
                    }
                }
                catch (Exception){}

            }
        }

        private void Click(object sender, RoutedEventArgs e)
        {
            Button messageButton = (Button)sender;
            var a = messageButton.Tag.ToString();
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
