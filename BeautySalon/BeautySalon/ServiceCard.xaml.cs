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
    /// Логика взаимодействия для ServiceCard.xaml
    /// </summary>
    public partial class ServiceCard : UserControl
    {
        public int ID { get; set; }
        public string nameStr { get; set; }
        public int price { get; set; }
        public int duration { get; set; } = 0;
        public int discount { get; set; } = 0;

        public ServiceCard()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        public int update()
        {
            try
            {
                NameLabel.Content = nameStr;
                if (discount != 0)
                {
                    OldPriceLabel.Content = String.Format("Old price: " + price);
                    PriceLabel.Content = String.Format((price-((price/100)*discount)) + " рублей за " + duration + " минут");
                    DiscountLabel.Content = String.Format("* скидка " + discount + "%");
                    BrushConverter brushConverter = new BrushConverter();
                    Brush brush = (Brush)brushConverter.ConvertFromString("#A3F06C");
                    CardGrid.Background = brush;
                }
                else
                {
                    PriceLabel.Content = String.Format(price + " рублей за " + duration + " минут");
                    //Note Первый костыль
                    DiscountLabel.Content = String.Format(" ");
                }

                return 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            update();
        }
    }
}
