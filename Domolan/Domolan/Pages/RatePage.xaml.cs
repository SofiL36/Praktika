using Domolan.Helpers;
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
using System.Windows.Shapes;

namespace Domolan.Pages
{
    /// <summary>
    /// Interaction logic for RatePage.xaml
    /// </summary>
    public partial class RatePage : Page
    {
        public RatePage()
        {
            InitializeComponent();

            PageHelper.PageName.Text = "Тарифы";

            var product = PageHelper.ConnectDb.Тарифы;

            dgProduct.ItemsSource = product.ToList();
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            PageHelper.MainFrame.GoBack();
            PageHelper.PageName.Text = "Главное меню";
        }

        private void btnredtarif_Click(object sender, RoutedEventArgs e)
        {
            PageHelper.MainFrame.Navigate(new ChangeRatePage());
        }

        private void btnaddtarif_Click(object sender, RoutedEventArgs e)
        {
            PageHelper.MainFrame.Navigate(new AddRatePage());
        }
    }
}
