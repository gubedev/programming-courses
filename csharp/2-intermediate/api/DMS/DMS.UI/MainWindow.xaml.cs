using System.Windows;

namespace DMS.UI
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            BasicWindow basicWindow = new BasicWindow();
            basicWindow.Show();
        }

        private void OpenDataGrid_Click(object sender, RoutedEventArgs e)
        {
            DataGridWindow dataGridWindow = new DataGridWindow();
            dataGridWindow.Show();
        }

        private void OpenListView_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OpenDataTemplate_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
