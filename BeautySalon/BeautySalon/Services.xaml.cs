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

namespace BeautySalon
{
    /// <summary>
    /// Логика взаимодействия для Services.xaml
    /// </summary>
    public partial class Services : UserControl
    {
        public int role { get; set; }

        public Services()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public void updataServicesList()
        {
            for(int i = 0; i < 10; i++)
            {
                ServiceCard serviceCard = new ServiceCard();
                serviceCard.nameStr = String.Format("Услуга " + i);
                serviceCard.price = 100 * (i+1);
                serviceCard.discount = (i % 2) * 10;
                ServicesSP.Children.Add(serviceCard);
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            if (role == 1)
            {
                AddButton.Visibility = Visibility.Visible;
            }
            updataServicesList();
        }
    }
}
