using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using YAMVVM;

namespace Test.WPF.ViewModels
{
    class StudentListViewModel : ViewModelBase
    {
        public StudentListViewModel()
        {
            Students = new ObservableCollection<StudentViewModel>();

            var s1 = new StudentViewModel();
            s1.Name = "Gigi";
            s1.Age = 12;

            var s2 = new StudentViewModel();
            s2.Name = "Lalu";
            s2.Age = 23;

            var s3 = new StudentViewModel();
            s3.Name = "Marin";
            s3.Age = 11;

            Students.Add(s1);
            Students.Add(s2);
            Students.Add(s3);

            Color = Brushes.Black;
        }

        private StudentViewModel currentStudent;
        public StudentViewModel CurrentStudent
        {
            get => currentStudent;
            set
            {
                currentStudent = value;
                OnPropertyChanged();
            }
        }

        private IList<StudentViewModel> students;
        public IList<StudentViewModel> Students
        {
            get => students;
            set
            {
                students = value;
                OnPropertyChanged();
            }
        }

        private Brush color;
        public Brush Color
        {
            get => color;
            set
            {
                color = value;
                OnPropertyChanged();
            }
        }

        public ICommand ChangeItemsColorCommand
        {
            get => new RelayCommand(c =>
            {
                Random rnd = new Random();
                PropertyInfo[] props = typeof(Brushes).GetProperties();
                int i = rnd.Next(0, props.Length);
                Color = props[i].GetValue(null) as SolidColorBrush;
            });
        }
    }
}
