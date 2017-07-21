using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private string _welcomeText = "Hallo MVVM!";
        public string WelcomeText
        {
            get => _welcomeText;
            set
            {
                _welcomeText = value;
                RaisePropertyChanged2();
            }
        }

        // for Lists<> : use ObservableCollection()
        // public ObservableCollection<string> WelcomeFriends = new ObservableCollection<string> { "Fred", "Peter", "Hanna" };
    }
}
