using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;

namespace WolvenKit.ViewModels.Validators;

public partial class DepotPathValidationRule : ValidationRule
{
    public static DepotPathValidationRule Instance { get; } = new();

    public override ValidationResult Validate(object value, CultureInfo cultureInfo)
    {
        if (value?.ToString() is not string content || string.IsNullOrWhiteSpace(content))
        {
            return new ValidationResult(false, "Cannot be empty.");
        }

        if (UpperCaseLettersRegex().IsMatch(content))
        {
            return new ValidationResult(false, "No uppercase letters allowed in depot path. STOP SHOUTING!");
        }
        
        if (content.Length < 4)
        {
            return new ValidationResult(false, "At least 4 characters");
        }

        if (content.Contains(' '))
        {
            return new ValidationResult(false, "No spaces allowed in depot path. Use _ instead!");
        }

        return ValidationResult.ValidResult;
    }

    [GeneratedRegex("[A-Z]")]
    private static partial Regex UpperCaseLettersRegex();
}