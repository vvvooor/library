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
    /// Логика взаимодействия для loginwindow.xaml
    /// </summary>
    public partial class loginwindow : Window
    {
        public loginwindow()
        {
            InitializeComponent();
          

        }

        private void RemoveTextPassword(object sender, RoutedEventArgs e)
        {
            txtPasswordPlaceholder.Visibility = Visibility.Collapsed;
            txtPassword.Visibility = Visibility.Visible;
            txtPassword.Focus();
        }

        private void loginwindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Логика при загрузке окна
        }

        private void ButtonNext_Click(object sender, RoutedEventArgs e)
        {
            // Логика при нажатии кнопки "Далее"
            OpenNewPage();
        }

        private void OpenNewPage()
        {
            // Создание новой страницы или окна и переход к ней
            mainpapage newPage = new mainpapage(); // Замените YourNewPage на имя вашей новой страницы
            newPage.Show();
            this.Close(); // Закрытие текущего окна
        }


    }
}
