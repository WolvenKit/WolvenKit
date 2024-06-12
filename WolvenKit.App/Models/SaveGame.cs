using System;

namespace WolvenKit.App.Models;

public class SaveGame(string dirName, string screenshot, string save, DateTime lastModified)
{
    public string DirName { get; set; } = dirName;
    public string Screenshot { get; set; } = screenshot;
    public string Save { get; set; } = save;
    public DateTime LastModified { get; set; } = lastModified;
}