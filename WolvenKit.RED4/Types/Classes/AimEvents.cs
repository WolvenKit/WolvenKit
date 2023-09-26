
namespace WolvenKit.RED4.Types
{
	public partial class AimEvents : CarriedObjectEvents
	{
		public AimEvents()
		{
			StyleName = "CarriedObject.Style";
			ForceStyleName = "CarriedObject.ForcedStyle";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
