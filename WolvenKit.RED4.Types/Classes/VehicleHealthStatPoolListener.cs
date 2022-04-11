using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleHealthStatPoolListener : gameCustomValueStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<vehicleBaseObject> Owner
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}
	}
}
