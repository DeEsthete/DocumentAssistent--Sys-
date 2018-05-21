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
    /// Логика взаимодействия для SignUpPage.xaml
    /// </summary>
    public partial class SignUpPage : Page
    {
        private Window _window;

        public SignUpPage(Window window)
        {
            InitializeComponent();
            _window = window;
        }

        private void SignUpButtonClick(object sender, RoutedEventArgs e)
        {
            using (DocumentContext context = new DocumentContext())
            {
                try
                {
                    if (context.Users.Any(userr => userr.Login == loginTextBox.Text))
                    {
                        if (passwordTextBox.Text != "")
                        {
                            MessageBox.Show("Не все поля заполнены верно");
                        }
                    }

                    Person person = new Person();
                    person.Age = int.Parse(ageTextBox.Text);
                    person.FullName = fullNameTextBox.Text;
                    User user = new User();
                    user.Login = loginTextBox.Text;
                    user.Password = passwordTextBox.Text;
                    user.PersonId = person.Id;
                    context.Users.Add(user);
                    context.People.Add(person);
                    context.SaveChanges();
                    _window.Content = new SignInPage(_window);
                }
                catch
                {
                    MessageBox.Show("Не все поля заполнены верно");
                }
            }
        }
    }
}
