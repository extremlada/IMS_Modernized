using IMS_Modernized.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Modernized.MVVM.ViewModel
{
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand ReportsViewCommand { get; set; }
        public ReportsViewModel ReportsVM { get; set; }
        public HomeViewModel HomeVM { get; set; }

        private object _currentView ;

        public object CurrentView
        {
            get { return _currentView; }
            set 
            { 
                _currentView = value;
                OnPropertyChanged();
            }
        }


        public MainViewModel() 
        { 
            HomeVM = new HomeViewModel();
            ReportsVM = new ReportsViewModel();
            CurrentView = HomeVM;
            HomeViewCommand = new RelayCommand(o => 
            { 
                CurrentView = HomeVM;
            });
            ReportsViewCommand = new RelayCommand(o =>
            {
                 CurrentView = ReportsVM;
            });
        }
    }
}
