
namespace WolvenKit.RED4.Types
{
	public partial class DisposeEvents : CarriedObjectEvents
	{
		public DisposeEvents()
		{
			StyleName = "CarriedObject.Style";
			ForceStyleName = "CarriedObject.ForcedStyle";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
