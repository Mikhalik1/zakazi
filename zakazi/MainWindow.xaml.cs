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
            Servcombobox.ItemsSource = db.context.Service.ToList();
            zalkazview.ItemsSource = db.context.Zakazi.ToList();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(seria.Text) && !string.IsNullOrWhiteSpace(cost.Text) && vid > 0)
            {
                if (cost.Text.All(x => Char.IsDigit(x)))
                {
                    Zakazi zakazi = new Zakazi
                    {
                        seriya = seria.Text,
                        cost = Convert.ToInt32(cost.Text),
                        id_servise = vid
                    };
                    db.context.Zakazi.Add(zakazi);
                    if (1 < db.context.SaveChanges())
                    {
                        MessageBox.Show("Запись не добавлена");
                    }
                    else
                    {
                        MessageBox.Show("Запись есть");
                        zalkazview.ItemsSource = db.context.Zakazi.ToList();

                    }
                }
                else
                {
                    MessageBox.Show("Вы ввели буквы");
                }
                
            }
            else
            {
                MessageBox.Show("поле не заполнено");
            }
            

            
            
        }

        private void Servcombobox_chenge(object sender, SelectionChangedEventArgs e)
        {
            
            vid = Convert.ToInt32(Servcombobox.SelectedValue);
        }
    }
}
