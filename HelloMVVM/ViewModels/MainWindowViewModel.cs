using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMVVM.ViewModels
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _welcomeText = "Hallo MVVM!";
        public string WelcomeText {
            get => _welcomeText;
            set {
                _welcomeText = value;
                var threadtmp = PropertyChanged;
                if(threadtmp != null)
                    PropertyChanged(this, new PropertyChangedEventArgs("WelcomeText"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
