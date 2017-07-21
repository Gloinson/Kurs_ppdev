using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloMVVM.ViewModels
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        private void RaisePropertyChanged([CallerMemberName] string param = null)
        {
            // to avoid threading-problems
            // does not solve problem with self-disposed event-receiver
            var threadtmp = PropertyChanged;
            if (threadtmp != null)
                PropertyChanged(this, new PropertyChangedEventArgs(param));

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(param));
        }

        private string _welcomeText = "Hallo MVVM!";
        public string WelcomeText
        {
            get => _welcomeText;
            set
            {
                _welcomeText = value;
                RaisePropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
