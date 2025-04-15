using GemBox.Document;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GemboxBookmarkTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ProcessButton_Click(object sender, RoutedEventArgs e)
        {
            GemBox.Document.ComponentInfo.SetLicense(BundleKeyTextBox.Text);
            string filePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DocumentTemplate", "Template.docx");

            // Use this for Windows Authentication with certificate trust
            DocumentModel document = DocumentModel.Load(filePath);
            var bookmarks = document.Bookmarks.ToList();
            var document2 = document.Clone(true);
            var bookmarks2 = document2.Bookmarks.ToList();
        }
    }
}