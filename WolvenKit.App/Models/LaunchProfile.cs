using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.RED4.Compiled;

namespace WolvenKit.App.Models;
public class LaunchProfile
{
    [Category("General")]
    [Display(Name = "Create Backup")]
    public bool CreateBackup { get; set; }

    [Category("Install")]
    [Display(Name = "Install to Game")]
    public bool Install { get; set; }
    // installsound files
    // install tweak files
    // install script files

    [Category("REDmod")]
    [Display(Name = "Pack as REDmod")]
    public bool IsRedmod { get; set; }

    [Category("REDmod")]
    [Display(Name = "Deploy With REDmod")]
    public bool DeployWithRedmod { get; set; }

    [Category("Game Launch")]
    [Display(Name = "Launch Game after Installing")]
    public bool LaunchGame { get; set; }

    [Category("Game Launch")]
    [Display(Name = "Game Commandline Arguments")]
    public string GameArguments { get; set; }


    internal LaunchProfile Copy()
    {
        return new LaunchProfile()
        {
            CreateBackup = CreateBackup,
            Install = Install,
            IsRedmod = IsRedmod,
            DeployWithRedmod = DeployWithRedmod,
            LaunchGame = LaunchGame,
            GameArguments = GameArguments
        };
    }
}
