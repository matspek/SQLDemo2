using Microsoft.EntityFrameworkCore;
using SQLDemo2.Data;
using SQLDemo2.DB;
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

namespace SQLDemo2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StudentDBContext _dbContext;
        public MainWindow()
        {
            InitializeComponent();
            _dbContext = new StudentDBContext();
            LoadStudents();
        }
        private void LoadStudents()
        {
            var Students = _dbContext.Students.ToList();
            StudentListBox.ItemsSource = Students;
        }

        private void AddStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            var studentName = StudentNameTextBox.Text;
            var newStudent = new Student();
            newStudent.Name = studentName;
        }
    }
}
