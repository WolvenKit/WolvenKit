using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleHealthStatPoolListener : gameCustomValueStatPoolsListener
	{
		private CWeakHandle<vehicleBaseObject> _owner;

		[Ordinal(0)] 
		[RED("owner")] 
		public CWeakHandle<vehicleBaseObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}
	}
}
