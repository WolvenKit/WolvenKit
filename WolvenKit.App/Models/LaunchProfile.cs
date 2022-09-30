using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WolvenKit.App.Models;
public class LaunchProfile
{
    public bool CreateBackup { get; set; }
    public bool Install { get; set; }
    // installsound files
    // install tweak files
    // install script files


    public bool DeployWithRedmod { get; set; }

    //hot reload

    public bool LaunchGame { get; set; }
    public string GameArguments { get; set; }

    internal LaunchProfile Copy()
    {
        return new LaunchProfile()
        {
            CreateBackup = CreateBackup,
            Install = Install,
            DeployWithRedmod = DeployWithRedmod,
            LaunchGame = LaunchGame,
            GameArguments = GameArguments
        };
    }
}
