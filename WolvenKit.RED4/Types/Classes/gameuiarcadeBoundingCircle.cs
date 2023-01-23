
namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeBoundingCircle : gameuiarcadeBoundingShape
	{
		public gameuiarcadeBoundingCircle()
		{
			BoundingShape = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
