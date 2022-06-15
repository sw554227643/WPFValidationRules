using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;

namespace WpfApp1
{
    public class NumberRule: ValidationRule
    {
        // 添加ErrorMessage字段，用于自定义错误提示
        public string ErrorMessage { get; set; }
        public double Minimum { get; set; }
        public double Maximum { get; set; }
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            double number;
            if (!double.TryParse(value.ToString(), out number))
            {
                return new ValidationResult(false, "Invalid number format");
            }
            if (number > Maximum || number < Minimum)
            {
                if (!string.IsNullOrEmpty(ErrorMessage))
                {
                    return new ValidationResult(false, ErrorMessage);
                }
                else
                {
                    return new ValidationResult(false, string.Format("Value should between {0} and {1}", Minimum, Maximum));
                }

            }
            return ValidationResult.ValidResult;
        }

       
    }
}
