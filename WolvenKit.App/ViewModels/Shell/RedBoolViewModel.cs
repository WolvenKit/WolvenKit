using WolvenKit.RED4.Types;

namespace WolvenKit.App.ViewModels.Shell;

// We can probably make this with generic types
public class RedBoolViewModel : ChunkPropertyViewModel
{
    public RedBoolViewModel(IRedPrimitive<bool> prop) : base(prop) { }
}
