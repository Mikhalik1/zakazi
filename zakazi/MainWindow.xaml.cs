using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
using zakazi.Model;

namespace zakazi
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Core db = new Core();
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var  = new Service
            {
                Title = TBoxTitle.Text,
                Cost = decimal.Parse(TBoxCost.Text),
                DurationInSeconds = TBoxDuration.Text,
                Description = TBoxDescription.Text,
                Discount = string.IsNullOrWhiteSpace(TBoxDuration.Text)
                      ? 0 : double.Parse(TBoxDiscount.Text) / 100,
                MainImagePath = Convert.ToInt32(_MainImagePath),
            };
            db.context.Services.Add(service);
            db.context.SaveChanges();
        }
    }
}
