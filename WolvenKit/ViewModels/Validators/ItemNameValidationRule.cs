using System.Globalization;
using System.Windows.Controls;

namespace WolvenKit.ViewModels.Validators;

public class ItemNameValidationRule(int minLength) : ValidationRule
{
    public ItemNameValidationRule() : this(4)
    {
    }

    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        if (value?.ToString() is not string content || string.IsNullOrWhiteSpace(content))
        {
            return new ValidationResult(false, "Item name cannot be empty");
        }

        if (content.Length < minLength)
        {
            return new ValidationResult(false, $"At least {minLength} characters");
        }

        if (content.Contains(' '))
        {
            return new ValidationResult(false, "No spaces allowed in item name. Use _ instead!");
        }

        if (content.Contains('.'))
        {
            return new ValidationResult(false, "No . allowed in item name");
        }

        return ValidationResult.ValidResult;
    }
}