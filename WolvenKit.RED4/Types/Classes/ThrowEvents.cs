
namespace WolvenKit.RED4.Types
{
	public partial class ThrowEvents : CarriedObjectEvents
	{
		public ThrowEvents()
		{
			StyleName = "CarriedObject.Style";
			ForceStyleName = "CarriedObject.ForcedStyle";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
