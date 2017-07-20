using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Validation.ValidationRules
{
    public class MustNotBeModulo2ValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if(value is double c)
            {
                var i = (int)c;
                if ((i % 2) == 0)
                    return new ValidationResult(false, "Value must not be modulo 2.");
            }
            return ValidationResult.ValidResult;
        }
    }
}
