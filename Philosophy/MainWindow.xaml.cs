using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.IO;

namespace Philosophy
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainPage mp = new MainPage();

            mp.StartSearch = (str) => App.Current.Dispatcher.Invoke(() => 
            {
                PageControl.ShowPage(new SearchPage(str) { AnotherSearch=NewSearch});
            });
            PageControl.ShowPage(mp);
        }

        private void NewSearch(string text)
        {
            App.Current.Dispatcher.Invoke(() =>
            {
                PageControl.TransitionType = WpfPageTransitions.PageTransitionType.GrowAndFade;
                PageControl.ShowPage(new SearchPage(text) { AnotherSearch = NewSearch });
            });
        }

    }
}
