using WolvenKit.Common.Model;

namespace WolvenKit.Common
{
    /// <summary>
    /// Abstract implementation for Witcher archive managers
    /// e.g. bundle, soundcache, collisioncache etc
    /// </summary>
    public abstract class RED3ArchiveManager : WolvenKitArchiveManager
    {
        protected readonly string[] VanillaDlClist = new string[]
        {
            "DLC1", "DLC2", "DLC3", "DLC4", "DLC5", "DLC6", "DLC7", "DLC8", "DLC9", "DLC10", "DLC11", "DLC12",
            "DLC13", "DLC14", "DLC15", "DLC16", "bob", "ep1"
        };


    }
}
