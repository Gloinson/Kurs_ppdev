﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ItemControlMVVM.ViewModels
{
    public class TestViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> Personen { get; set; }

        public Person Person { get; set; } =
            new Person()
            {
                Name = "Muhtens",
                Arm = new Arme() { Bezeichnung = "urkslik", Abmessungen = new int[] { 11, 12, 13 } }
            };

        public TestViewModel()
        {
            Personen = new ObservableCollection<Person>
            {
                new Person()
                {
                    Name = "Fred",
                    Arm = new Arme() {Bezeichnung = "links", Abmessungen = new int[] {1, 2, 3}}
                },
                new Person()
                {
                    Name = "Hans",
                    Arm = new Arme() {Bezeichnung = "oben", Abmessungen = new int[] {3, 4, 5}}
                },
                new Person()
                {
                    Name = "Peter",
                    Arm = new Arme() {Bezeichnung = "unten", Abmessungen = new int[] {6, 7, 8}}
                },
                new Person()
                {
                    Name = "Tina",
                    Arm = new Arme() {Bezeichnung = "rechts", Abmessungen = new int[] {9, 9, 9}}
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}