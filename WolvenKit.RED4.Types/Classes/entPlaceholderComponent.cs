
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entPlaceholderComponent : entIPlacedComponent
	{

		public entPlaceholderComponent()
		{
			Name = "entPlaceholderComponent";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };
		}
	}
}
