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
using System.Windows.Shapes;

namespace gamelibr
{
    /// <summary>
    /// Логика взаимодействия для regestration.xaml
    /// </summary>
    public partial class regestration : Window
    {
        public regestration()
        {
            InitializeComponent();
        }

        private void RemoveTextPassword(object sender, RoutedEventArgs e)
        {
            // Удаление текста-плейсхолдера при получении фокуса на поле пароля
            txtPasswordPlaceholder.Visibility = System.Windows.Visibility.Collapsed;
            txtPassword.Visibility = System.Windows.Visibility.Visible;
            txtPassword.Focus();
        }
    }
}
