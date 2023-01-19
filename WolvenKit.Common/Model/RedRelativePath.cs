using System.IO;

namespace WolvenKit.Common.Model
{
    public class RedRelativePath
    {
        public DirectoryInfo BaseDirectory { get; set; }
        public string RelativePath { get; set; }

        public RedRelativePath(DirectoryInfo baseDirectory, string relativePath)
        {
            BaseDirectory = baseDirectory;
            RelativePath = relativePath;
        }

        public RedRelativePath(RedRelativePath redRelative)
        {
            BaseDirectory = redRelative.BaseDirectory;
            RelativePath = redRelative.RelativePath;
        }

        public string FullPath => Path.Combine(BaseDirectory.FullName, RelativePath);
        public string FullName => FullPath;
        public string Name => Path.GetFileName(FullPath);
        public string NameWithoutExtension => Path.GetFileNameWithoutExtension(FullPath);

        public bool Exists => File.Exists(FullName);

        public string Extension => Path.GetExtension(RelativePath).TrimStart('.');

        public RedRelativePath ChangeBaseDir(DirectoryInfo newbase)
        {
            BaseDirectory = newbase;
            return this;
        }

        public RedRelativePath ChangeRelativePath(string newpath)
        {
            RelativePath = newpath;
            return this;
        }

        public RedRelativePath ChangeExtension(string newExt)
        {
            RelativePath = Path.ChangeExtension(RelativePath, newExt);
            return this;
        }

        public string GetFullPathFor(DirectoryInfo newBaseDir) => Path.Combine(newBaseDir.FullName, RelativePath);

        public FileInfo ToFileInfo() => new(FullPath);

        public override string ToString() => FullPath;
    }
}
