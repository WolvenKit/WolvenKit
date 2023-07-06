
namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeBoundingCircle : gameuiarcadeBoundingShape
	{
		public gameuiarcadeBoundingCircle()
		{
			BoundingShape = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
