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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Content = new SignInPage(this);

            //using (DocumentContext context = new DocumentContext())
            //{
            //    var result = from d in context.Documents
            //                 join s in context.Signatures
            //                 on d.Id equals s.DocumentId
            //                 join p in context.People
            //                 on s.PersonId equals p.Id
            //                 select new { d.Id, d.DocumentTheme, d.DocumentCreator, d.CreationDate, PersonName = d.Signatures.Select(s => s.Person.FullName) };
            //}
        }
    }
}
