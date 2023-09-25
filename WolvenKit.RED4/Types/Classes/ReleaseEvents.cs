
namespace WolvenKit.RED4.Types
{
	public partial class ReleaseEvents : CarriedObjectEvents
	{
		public ReleaseEvents()
		{
			StyleName = "CarriedObject.Style";
			ForceStyleName = "CarriedObject.ForcedStyle";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
