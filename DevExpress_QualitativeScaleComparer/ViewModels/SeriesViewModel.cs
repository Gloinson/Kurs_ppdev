using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace DevExpress_QualitativeScaleComparer.ViewModels
{
    public class SeriesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<DataPoints> MTD {
            get;
            private set;
        }

        public SeriesViewModel()
        {
            MTD = new ObservableCollection<DataPoints>
            {
                new DataPoints {Series="S2", Argument = "4", Value = 4},
                new DataPoints {Series="S1", Argument = "three", Value = 3},

                new DataPoints {Series="S1", Argument = "one", Value = 1},
                new DataPoints {Series="S1", Argument = "two", Value = 2},
                new DataPoints {Series="S2", Argument = "1", Value = 1},
                new DataPoints {Series="S2", Argument = "2", Value = 2},
                new DataPoints {Series="S2", Argument = "3", Value = 3}
            };
            OnPropertyChanged(nameof(MTD));
        }

        public class DataPoints
        {
            public string Series { get; set; }
            public int Value { get; set; }
            public string Argument { get; set; }
        }
    }
}
