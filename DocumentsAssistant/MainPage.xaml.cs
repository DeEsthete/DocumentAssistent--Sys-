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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        private Window _window;
        private User _user;

        public MainPage(Window window, User user)
        {
            InitializeComponent();
            _window = window;
            _user = user;
            
            using (DocumentContext context = new DocumentContext())
            {
                List<Document> documents;
                documents = context.Documents.ToList();
                for (int i = 0; i < 0; i++)
                {
                    if (documents[i].DocumentCreator == _user.Person)
                    {
                        DocumentEntity temp = new DocumentEntity(documents[i]);
                        documentListBox.Items.Add(temp);
                    }
                }
            }  
        }

        private void AddDocumentButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void OfferButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteDocumentButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteProposedButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void SubscribeButtonClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
