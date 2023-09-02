
namespace WolvenKit.RED4.Types
{
	public partial class gameuiarcadeBoundingRect : gameuiarcadeBoundingShape
	{
		public gameuiarcadeBoundingRect()
		{
			BoundingShape = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
