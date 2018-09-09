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

namespace TkSqlFormatter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlFormatter formatter;

        public MainWindow()
        {
            InitializeComponent();
            formatter = new SqlFormatter();
        }

        private void btnFormat_Click(object sender, RoutedEventArgs e)
        {
            SqlOutput.Text = formatter.FormatSql(SqlInput.Text);
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(formatter.AboutMessage(), "About", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
