using System;
using System.Collections.Generic;
using System.Text;
using Test.WPF.Models;
using YAMVVM;

namespace Test.WPF.ViewModels
{
    class StudentViewModel : ViewModel<Student>
    {
        public StudentViewModel() : base(new Student()) 
        { 
        
        }
        public string Name
        {
            get => Model.Name;
            set
            {
                Model.Name = value;
                OnPropertyChanged();
            }
        }

        public int Age
        {
            get => Model.Age;
            set
            {
                Model.Age = value;
                OnPropertyChanged();
            }
        }
    }
}
