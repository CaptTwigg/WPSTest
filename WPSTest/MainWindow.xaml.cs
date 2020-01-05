using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using WPSTest.models;

namespace WPSTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        public override void EndInit()
        {
            base.EndInit();
            deviceBtn.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            deviceBtn.Focus();
        }
        void OnClick(Object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            String btnTxt = btn.Content.ToString();
            if (btnTxt.Equals("Devices"))
            {
                DataContext = new DeviceModel();
            }
            else if (btnTxt.Equals("Cable view"))
            {
                DataContext = new CableModel();
            }
            else if (btnTxt.Equals("Artifacts"))
            {
                DataContext = new ArtifactModel();
            }
        }

        private void GotFocusBtn(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Foreground = Brushes.Blue;
        }

        private void LostFocusBtn(object sender, RoutedEventArgs e)
        {

            Button btn = (Button)sender;
            Console.WriteLine(btn.Name);
            btn.Foreground = Brushes.White;
            //btn.ClearValue(Button.BackgroundProperty);
        }
    }
}
