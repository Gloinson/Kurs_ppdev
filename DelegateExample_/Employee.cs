using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateInPraxis
{
    class Employee
    {
        private int id;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;
        public string Name
        {
            get => $"Mr/Ms {name}";
            set => name = value;
        }
        public int Experience { get; set; }
    }
}
