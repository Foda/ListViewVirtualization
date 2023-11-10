using Microsoft.UI.Xaml;
using System.Linq;

namespace WinUIPlayground
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();

            cvGrid.ItemTemplate = (DataTemplate)App.Current.Resources["ItemsViewDefaultTemplate"];
            cvGrid.ItemsSource =
                Enumerable.Range(0, 1000)
                    .Select(x => new { Symbol = x })
                    .ToList();
        }
    }
}
