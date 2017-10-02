using GalaSoft.MvvmLight;
using Labo4.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo4.ViewModel
{
    public class MainPageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        private ObservableCollection<Student> _students;
        public ObservableCollection<Student> Students
        {
            get { return _students; }
            set {   _students = value;
                    RaisePropertyChanged("Students"); }
        }

        public MainPageViewModel()
        {
            Students = new ObservableCollection<Student>(AllStudents.GetAllStudents());
        }
    }
}
