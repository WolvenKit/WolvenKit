
namespace WolvenKit.RED4.Types
{
	public partial class gameEntityStubComponentPlacedProxy : entIPlacedComponent
	{
		public gameEntityStubComponentPlacedProxy()
		{
			Name = "entityStubPlacedProxy";
			LocalTransform = new() { Position = new() { X = new(), Y = new(), Z = new() }, Orientation = new() { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
