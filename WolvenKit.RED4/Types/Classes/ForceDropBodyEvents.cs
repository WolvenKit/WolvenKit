
namespace WolvenKit.RED4.Types
{
	public partial class ForceDropBodyEvents : CarriedObjectEvents
	{
		public ForceDropBodyEvents()
		{
			StyleName = "CarriedObject.Style";
			ForceStyleName = "CarriedObject.ForcedStyle";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
