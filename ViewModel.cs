using System;
using System.Collections.Generic;
using System.Text;

namespace YAMVVM
{
    public class ViewModel<T> : ViewModelBase
    {
        public ViewModel(T model)
        {
            Model = model;
        }
        private T model;
        public T Model
        {
            get => model;
            set
            {
                model = value;
                OnPropertyChanged();
            }
        }
    }
}
