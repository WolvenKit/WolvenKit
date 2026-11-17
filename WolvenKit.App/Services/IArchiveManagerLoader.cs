using System.Threading.Tasks;

namespace WolvenKit.App.Services;

public interface IArchiveManagerLoader
{
    const string ArchiveLoadingPurpose = "RED4Controller archive loading";

    Task LoadArchiveManagerAsync();
}
