
namespace WolvenKit.RED4.Types
{
	public partial class CarryEvents : CarriedObjectEvents
	{
		public CarryEvents()
		{
			StyleName = "CarriedObject.Style";
			ForceStyleName = "CarriedObject.ForcedStyle";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
