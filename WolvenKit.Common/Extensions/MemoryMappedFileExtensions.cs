using System.IO;
using System.IO.MemoryMappedFiles;

namespace WolvenKit.Common.Extensions
{
    public static class MemoryMappedFileExtensions
    {
        public static MemoryMappedFile GetMemoryMappedFile(FileStream fs, string mapName)
        {
            try
            {
#pragma warning disable CA1416 // Validate platform compatibility
                return MemoryMappedFile.OpenExisting(mapName);
#pragma warning restore CA1416 // Validate platform compatibility
            }
            catch (System.IO.IOException)
            {
            }

            return MemoryMappedFile.CreateFromFile(fs, mapName, 0, MemoryMappedFileAccess.ReadWrite, HandleInheritability.None, true);
        }
    }
}
