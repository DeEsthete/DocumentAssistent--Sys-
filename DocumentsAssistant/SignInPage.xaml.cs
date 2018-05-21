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

namespace DocumentsAssistant
{
    /// <summary>
    /// Логика взаимодействия для SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {
        private Window _window;
        private User _user;

        public SignInPage(Window window)
        {
            InitializeComponent();
            _window = window;
        }

        private void SignUpButtonClick(object sender, RoutedEventArgs e)
        {
            _window.Content = new SignUpPage(_window);
        }

        private void LogInButtonClick(object sender, RoutedEventArgs e)
        {
            List<User> users;
            List<Person> people;

            using (DocumentContext context = new DocumentContext())
            {
                users = context.Users.ToList();
                people = context.People.ToList();

                bool IsCorrect = false;
                foreach (var i in users)
                {
                    if (loginTextBox.Text == i.Login)
                    {
                        if (passwordTextBox.Text == i.Password)
                        {
                            IsCorrect = true;
                            _user = i;
                        }
                    }
                }
                if (IsCorrect)
                {
                    _window.Content = new MainPage(_window, _user);
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                }
            }
        }
    }
}
