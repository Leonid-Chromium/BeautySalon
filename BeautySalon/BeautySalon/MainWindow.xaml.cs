using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int role { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
            myServices.role = role;
            Trace.WriteLine("Role = " + role);
        }

        public void SetRole(int newRole)
        {
            role = newRole;
            UseRole();
        }

        private void UseRole()
        {
            try
            {
                myServices.role = role;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Фатальная ошибка");
            }
        }
    }
}
