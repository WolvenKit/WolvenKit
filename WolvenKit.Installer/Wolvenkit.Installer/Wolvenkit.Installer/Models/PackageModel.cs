namespace Wolvenkit.Installer.Models;
public class PackageModel
{
    public PackageModel(string name, string version, string[] files, string path)
    {
        Version = version;
        Name = name;
        Files = files;
        Path = path;
    }

    public string Name { get; set; }
    public string Path { get; set; }
    public string Version { get; set; }
    public string[] Files { get; set; }
}
