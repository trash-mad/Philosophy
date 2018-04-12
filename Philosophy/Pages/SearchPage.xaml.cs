using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Reflection;

namespace Philosophy
{
    class SearchItem
    {
        public SearchItem() { }
        public Action Click { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
    }
    public partial class SearchPage : UserControl
    {
        public Action<string> AnotherSearch { get; set; }
        private ObservableCollection<SearchItem> SearchList = new ObservableCollection<SearchItem>();

        public SearchPage(string text)
        {
            InitializeComponent();
            SearchBox.Text = text;
            CurrentList.ItemsSource = SearchList;

            foreach (var item in Model.DefaultItem)
            {
                if (item.Title.ToLower().IndexOf(text.ToLower()) > -1)
                {
                    SearchList.Add(new SearchItem() { Title = PrepareTitle(item.Title), Type = item.Type });
                    Console.WriteLine(item.Title);
                    if (item is ImageItem)
                    {
                        SearchList.Last().Click = () => ShowImage((item as ImageItem).Image);
                    }
                    else if(item is MapItem)
                    {
                        SearchList.Last().Click = () => ExecBinary((item as MapItem).ExeName);
                    }
                }
            }
        }


        private void ExecBinary(string path)
        {
            string exname = Path.Combine(Path.GetTempPath(), path);
            if (!File.Exists(exname))
            {
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "Philosophy.Binaries." + path;
                using (Stream source = assembly.GetManifestResourceStream(resourceName))
                using (FileStream stream = new FileStream(exname, FileMode.CreateNew, FileAccess.Write))
                {
                    source.CopyTo(stream);
                }
            }
            System.Diagnostics.Process.Start(exname);
        }

        private void ShowImage(string path)
        {
            App.Current.Dispatcher.Invoke(() =>
            {
                ImageViewer iv = new ImageViewer(path);
                iv.Show();
            });
        }

        private string PrepareTitle(string text)
        {
            if (text.Length < 25) return text;
            else
            {
                text = text.Substring(0, 25);
                return text + "...";
            }
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            AnotherSearch?.Invoke(SearchBox.Text);
        }

        private void CurrentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (CurrentList.SelectedItem == null) return;
            (CurrentList.SelectedItem as SearchItem).Click();
        }
    }
}
