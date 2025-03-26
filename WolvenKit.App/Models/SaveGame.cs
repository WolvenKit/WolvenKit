using System;

namespace WolvenKit.App.Models;

public class SaveGame
{
    public SaveGame(string dirName, string screenshot, string save, DateTime lastModified)
    {
        DirName = dirName;
        Screenshot = screenshot;
        Save = save;
        LastModified = lastModified;
    }

    public string DirName { get; set; }
    public string Screenshot { get; set; }
    public string Save { get; set; }
    public DateTime LastModified { get; set; } 
}