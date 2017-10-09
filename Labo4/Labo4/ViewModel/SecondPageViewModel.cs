using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Views;
using Labo4.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Navigation;

namespace Labo4.ViewModel
{
    public class SecondPageViewModel : ViewModelBase, INotifyPropertyChanged
    {
        public Student SelectedStudent
        { get; set; }

        private INavigationService _navigationService;

        public SecondPageViewModel(INavigationService navigationService = null)
        {
            _navigationService = navigationService;
        }

        public void OnNavigatedTo(NavigationEventArgs e)
        {
            SelectedStudent = (Student)e.Parameter;
        }
    }
}
