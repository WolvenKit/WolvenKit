using System;
using System.IO;

namespace WolvenKit.Functionality.Helpers
{
    public static partial class Helpers
    {
        // Get Capture FilePath (Video Tool)
        public static string VideoPlayer_GetCaptureFilePath(string mediaPrefix, string extension)
        {
            var date = DateTime.UtcNow;
            var dateString = $"{date.Year:0000}-{date.Month:00}-{date.Day:00} {date.Hour:00}-{date.Minute:00}-{date.Second:00}.{date.Millisecond:000}";
            var targetFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "ffmeplay");

            if (!Directory.Exists(targetFolder))
            { Directory.CreateDirectory(targetFolder); }

            var targetFilePath = Path.Combine(targetFolder, $"{mediaPrefix} {dateString}.{extension}");

            if (File.Exists(targetFilePath))
            { File.Delete(targetFilePath); }

            return targetFilePath;
        }
    }
}
