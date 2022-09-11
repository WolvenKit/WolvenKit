
namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeBoundingRect : gameuiarcadeBoundingShape
	{
		public gameuiarcadeBoundingRect()
		{
			BoundingShape = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
