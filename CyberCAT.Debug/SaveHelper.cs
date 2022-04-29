using WolvenKit.RED4.Save;
using WolvenKit.RED4.Save.IO;

namespace CyberCAT.Debug;

public class SaveHelper
{
    public static string? GetSavePath(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        var path = Native.GetSavedGamesPath();
        if (path == null)
        {
            return null;
        }

        path = Path.Combine(path, "CD Projekt Red", "Cyberpunk 2077", name, "sav.dat");
        if (!File.Exists(path))
        {
            return null;
        }

        return path;
    }

    public static CyberpunkSaveFile? LoadSaveFile(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException(nameof(name));
        }

        var path = Native.GetSavedGamesPath();
        if (path == null)
        {
            return null;
        }

        path = Path.Combine(path, "CD Projekt Red", "Cyberpunk 2077", name, "sav.dat");
        if (!File.Exists(path))
        {
            return null;
        }

        using var ms = new MemoryStream(File.ReadAllBytes(path));
        var reader = new CyberpunkSaveReader(ms);

        if (reader.ReadFile(out var save) != EFileReadErrorCodes.NoError)
        {
            return null;
        }

        return save;
    }
}
