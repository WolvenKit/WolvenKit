
namespace WolvenKit.RED4.Types;

public partial class CBitmapTexture
{
    public override IEnumerable<string> GetReadonlyFieldNames()
    {
        return base.GetReadonlyFieldNames().Concat(["width", "height"]);
    }
}