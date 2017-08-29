using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevExpress_QualitativeScaleComparer.Comparer
{
    public class NumberComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            int iX = NumberConverter.ToInt(x);
            int iY = NumberConverter.ToInt(y);
            return iX - iY;
        }
    }

    class NumberConverter
    {
        public static int ToInt(object o)
        {
            string stringNumber = o as string;
            int number = 0;
            if (stringNumber == null) return -1;
            if (Int32.TryParse(stringNumber, out number))
                return number;
            switch (stringNumber.ToLower())
            {
                case "one": return 1;
                case "two": return 2;
                case "three": return 3;
            }
            return number;
        }
    }
}
