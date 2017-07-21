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
            if(value is string s && int.TryParse(s, out int d) && (d%2)==0)
                return new ValidationResult(false, "Value must not be modulo 2.");
            return ValidationResult.ValidResult;
        }
    }

    public class MustNotBeAlphanumeric : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            if(value is string s && !s.All(c => char.IsNumber(c) || char.IsPunctuation(c)))
                return new ValidationResult(false, "Value must be alpanumeric string.");
            return ValidationResult.ValidResult;
        }
    }
}
