
namespace WolvenKit.RED4.Types
{
	public partial class AVComponent : VehicleComponent
	{
		public AVComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
