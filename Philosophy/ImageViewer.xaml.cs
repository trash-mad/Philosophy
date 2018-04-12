using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Philosophy
{
    /// <summary>
    /// Логика взаимодействия для ImageViewer.xaml
    /// </summary>
    public partial class ImageViewer : Window
    {
        public ImageViewer(string resname)
        {
            InitializeComponent();

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Philosophy.Images."+resname;
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                var bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.StreamSource = stream;
                bitmap.CacheOption = BitmapCacheOption.OnLoad;
                bitmap.EndInit();
                bitmap.Freeze();

                CurrentImage.Source = bitmap;
            }
        }
    }
}
