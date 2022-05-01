using System.Runtime.InteropServices;

namespace CyberCAT.Forms;

internal static class Native
{
    private static Guid s_savedGamesGuid = new("4C5C32FF-BB9D-43b0-B5B4-2D72E54EAAA4");

    [DllImport("shell32.dll", CharSet = CharSet.Auto)]
    private static extern int SHGetKnownFolderPath(ref Guid id, int flags, IntPtr token, out IntPtr path);

    public static string? GetSavedGamesPath()
    {
        if (Environment.OSVersion.Version.Major < 6)
        {
            throw new NotSupportedException();
        }

        var pathPtr = IntPtr.Zero;
        try
        {
            SHGetKnownFolderPath(ref s_savedGamesGuid, 0, IntPtr.Zero, out pathPtr);
            return Marshal.PtrToStringUni(pathPtr);
        }
        finally
        {
            Marshal.FreeCoTaskMem(pathPtr);
        }
    }
}
