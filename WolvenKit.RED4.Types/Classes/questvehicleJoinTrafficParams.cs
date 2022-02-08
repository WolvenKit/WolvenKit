
namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questvehicleJoinTrafficParams : questVehicleSpecificCommandParams
	{

		public questvehicleJoinTrafficParams()
		{
			PushOtherVehiclesAside = true;
			SecureTimeOut = 60.000000F;
		}
	}
}
