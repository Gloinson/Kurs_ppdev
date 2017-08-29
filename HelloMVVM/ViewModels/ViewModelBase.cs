using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HelloMVVM.ViewModels
{
    internal abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged2([CallerMemberName] string param = null)
        {
            // inherently thread-safe, copying the value itself before usage
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(param));
        }
    }
}
