using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloMVVM.ViewModels
{
    abstract internal class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string param = null)
        {
            // to avoid threading-problems
            // does not solve problem with self-disposed event-receiver
            var threadtmp = PropertyChanged;
            if (threadtmp != null)
                PropertyChanged(this, new PropertyChangedEventArgs(param));
        }

        protected void RaisePropertyChanged2([CallerMemberName] string param = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(param));
        }
    }
}
