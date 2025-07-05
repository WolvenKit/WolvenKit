
namespace WolvenKit.RED4.Types
{
	public partial class questvehicleJoinTrafficParams : questVehicleSpecificCommandParams
	{
		public questvehicleJoinTrafficParams()
		{
			PushOtherVehiclesAside = true;
			SecureTimeOut = 60.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
