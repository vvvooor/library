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

namespace gamelibr
{
    /// <summary>
    /// Логика взаимодействия для add.xaml
    /// </summary>
    public partial class add : Window
    {
        public add()
        {
            InitializeComponent();
           
        }



    private void AddToLibraryButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика при нажатии кнопки "Добавить в библиотеку"
            // Добавьте здесь код для добавления игры в библиотеку
        }

        private void GoToLibraryButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика при нажатии кнопки "Перейти в библиотеку"
            OpenLibraryPage();
        }

        private void OpenLibraryPage()
        {
            // Открываем страницу библиотеки
            gamelibrary libraryPage = new gamelibrary();
            libraryPage.Show();
            this.Close();
        }

        private void TitleTextBox_TextChanged(object sender, RoutedEventArgs e)
        {
            // Логика при изменении текста в поле "Название игры"
            // Добавьте здесь логику обработки изменения названия игры
        }

    }
}
