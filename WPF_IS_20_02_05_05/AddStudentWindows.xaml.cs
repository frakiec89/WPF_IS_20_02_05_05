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
using System.Windows.Shapes;

namespace WPF_IS_20_02_05_05
{
    /// <summary>
    /// Логика взаимодействия для AddStudentWindows.xaml
    /// </summary>
    public partial class AddStudentWindows : Window
    {
        public AddStudentWindows()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text))
            {
                MessageBox.Show("Введите имя"); return;
            }
            if (string.IsNullOrEmpty(tbFamily.Text))
            {
                MessageBox.Show("Введите фамилию"); return;
            }
            if (string.IsNullOrEmpty(tbGroupName.Text))
            {
             MessageBox.Show("Введите название группы"); return;
            }

            DB.Student student = new DB.Student();
            student.Name = tbName.Text; 
            student.Family = tbFamily.Text;
            student.Telefone = tbTelefone.Text;
            student.GroupName = tbGroupName.Text;

            DB.MyDBContext context = new DB.MyDBContext();
            context.Students.Add(student);
            context.SaveChanges();
            MessageBox.Show("Объект добавлен в бд");
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
