using System.IO;
using System.Windows.Input;
using WolvenKit.App.Services;

namespace WolvenKit.App.Helpers;

// We do not want a switch case for every key under the sun
#pragma warning disable IDE0072
public class KeyboardHelper
{
    private static readonly KeyConverter s_keyConverter = new();

    public static bool IsAlphaNumericChar(Key key) => key is (>= Key.A and <= Key.Z)
        // Check for 0-9
        or (>= Key.D0 and <= Key.D9)
        // Check for numpad 0-9
        or (>= Key.NumPad0 and <= Key.NumPad9);


    /// <summary>
    /// Will check for alphanumeric characters and - and _
    /// </summary>
    public static bool IsAllowedFilenameKey(Key key) =>
        IsAlphaNumericChar(key) || (key is Key.OemMinus or Key.Subtract); // Check for '-' and '_'


    /// <summary>
    /// Will check for <see cref="IsAllowedFilenameKey"/> or <see cref="Path.DirectorySeparatorChar"/>
    /// </summary>
    public static bool IsAllowedFilePathChar(Key key) =>
        IsAllowedFilenameKey(key) || Stringify(key) == $"{Path.DirectorySeparatorChar}";

    private static readonly string s_directorySeparatorChar = Path.DirectorySeparatorChar.ToString();

    public static string Stringify(Key key)
    {
        if (IsAlphaNumericChar(key) && s_keyConverter.ConvertToString(key) is string { Length: 1 } s)
        {
            return ModifierViewStateService.IsShiftBeingHeld ? s : s.ToLower();
        }

        return key switch
        {
            Key.Subtract or
                Key.OemMinus => ModifierViewStateService.IsShiftBeingHeld ? "_" : "-",
            Key.Divide => s_directorySeparatorChar,
            Key.Oem4 => s_directorySeparatorChar,
            Key.OemBackslash => s_directorySeparatorChar,
            Key.Separator => s_directorySeparatorChar,
            _ => string.Empty
        };
    }
}
