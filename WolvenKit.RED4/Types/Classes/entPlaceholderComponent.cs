
namespace WolvenKit.RED4.Types
{
	public partial class entPlaceholderComponent : entIPlacedComponent
	{
		public entPlaceholderComponent()
		{
			Name = "entPlaceholderComponent";
			LocalTransform = new WorldTransform { Position = new WorldPosition { X = new FixedPoint(), Y = new FixedPoint(), Z = new FixedPoint() }, Orientation = new Quaternion { R = 1.000000F } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
