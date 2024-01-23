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
        int vid;
        public MainWindow()
        {
            
            InitializeComponent();
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var zakazi = new Zakazi
            {
                id_zakaz = 1,
                seriya = "gjgf,j,hf",
                cost = 100,
                id_servise = 2
            };
            db.context.Zakazi.Add(zakazi);
            db.context.SaveChanges();
        }

        private void Servcombobox_chenge(object sender, SelectionChangedEventArgs e)
        {
            
            vid = Convert.ToInt32(Servcombobox.SelectedValue);
        }
    }
}
