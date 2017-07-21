using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

        public ICommand ChangeTextCommand { get; }
        public ICommand ChangeTextCommand2 { get; }

        public MainWindowViewModel()
        {
            ChangeTextCommand = new RelayCommand(() => WelcomeText = "ViewModel says hello via Command");
            ChangeTextCommand2 = new RelayCommand(() => WelcomeText = "Wahouw!");
        }

        // for Lists<> : use ObservableCollection()
        // public ObservableCollection<string> WelcomeFriends = new ObservableCollection<string> { "Fred", "Peter", "Hanna" };
    }
}
