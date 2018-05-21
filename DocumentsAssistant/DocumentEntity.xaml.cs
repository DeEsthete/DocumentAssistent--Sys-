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
    /// Логика взаимодействия для DocumentEntity.xaml
    /// </summary>
    public partial class DocumentEntity : UserControl
    {
        public Document document;

        public DocumentEntity(Document doc)
        {
            InitializeComponent();
            document = doc;
            idTextBlock.Text = document.Id.ToString();
            nameTextBlock.Text = document.DocumentTheme;
        }
    }
}
