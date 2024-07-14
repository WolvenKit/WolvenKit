using System.IO;
using System.Windows.Controls;

namespace WolvenKit.Views.Validators;

public class FilePathValidationRule : ValidationRule
{
    public override ValidationResult Validate(object value, System.Globalization.CultureInfo cultureInfo)
    {
        var path = value as string;

        if (string.IsNullOrWhiteSpace(path))
        {
            return new ValidationResult(false, "Path is required.");
        }

        if (!Path.IsPathRooted(path) || !File.Exists(path))
        {
            return new ValidationResult(false, "Path must be a valid file path.");
        }

        return ValidationResult.ValidResult;
    }
}