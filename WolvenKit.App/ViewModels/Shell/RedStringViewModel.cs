using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

public class RedStringViewModel : ChunkPropertyViewModel
{
    public RedStringViewModel(IRedPrimitive<string> prop) : base(prop) { }
}
