using System;
using System.Collections.Generic;
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
    }
}
