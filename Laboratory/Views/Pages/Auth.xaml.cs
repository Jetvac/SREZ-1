using Laboratory.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Laboratory.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AccountData user = App.DBConnection.AccountDatas.FirstOrDefault(c => c.Login == Login.Text && c.Password == Password.Password);
            try
            {
                if (user != null)
                {
                    NavigationService.Navigate(new Pages.MainMenu());
                    MessageBox.Show("Вы успешно авторизировались!");
                }
                else
                {
                    MessageBox.Show("Аккаунт не найден!");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка соединения с базой данных!");
            }
        }
    }
}
