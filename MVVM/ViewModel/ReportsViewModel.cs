using IMS_Modernized.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS_Modernized.MVVM.ViewModel
{
    public class ReportsViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<TermekModel> termekList;

        public ObservableCollection<TermekModel> TermekList
        {
            get { return termekList; }
            set
            {
                termekList = value;
                OnPropertyChanged(nameof(TermekList));
            }
        }

        // Your commands and other logic can go here

        public ReportsViewModel()
        {
            TermekList = new ObservableCollection<TermekModel>(GetDataFromDatabase());
        }

        // Method to get data from the database
        private List<TermekModel> GetDataFromDatabase()
        {
            // Implement logic to retrieve data from the database and convert it to TermekModel objects
            // ...

            return new List<TermekModel>();
        }

        // Implement INotifyPropertyChanged interface
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}
