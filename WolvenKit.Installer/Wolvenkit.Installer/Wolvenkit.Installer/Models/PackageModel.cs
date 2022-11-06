namespace Wolvenkit.Installer.Models;
public class PackageModel
{
    public PackageModel(string name, string version, string[] files, string path, string executable)
    {
        Version = version;
        Name = name;
        Files = files;
        Path = path;
        Executable = executable;
    }

    public string Name { get; set; }
    public string Executable { get; set; }
    public string Path { get; set; }
    public string Version { get; set; }
    public string[] Files { get; set; }
}
