using System;
using System.Collections.Generic;
using System.Linq;

using System.Windows;


namespace WPF_IS_20_02_05_05
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
           DB.MyDBContext context = new DB.MyDBContext();

            var stList = context.Students.ToList();

            dgContent.ItemsSource= stList;
        }

        private void btAddStudetn_Click(object sender, RoutedEventArgs e)
        {
            AddStudentWindows windows = new AddStudentWindows();
            windows.Show();
            Close();
        }
    }
}
