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
    /// Interaction logic for ChangeRatePage.xaml
    /// </summary>
    public partial class ChangeRatePage : Page
    {
        public ChangeRatePage()
        {
            InitializeComponent();

            PageHelper.PageName.Text = "Редактирование тарифа";
        }

        private void btnChange_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
