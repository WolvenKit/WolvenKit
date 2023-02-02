using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMasterDeviceComponent : gameComponent
	{
		[Ordinal(4)] 
		[RED("clearance")] 
		public CHandle<gamedeviceClearance> Clearance
		{
			get => GetPropertyValue<CHandle<gamedeviceClearance>>();
			set => SetPropertyValue<CHandle<gamedeviceClearance>>(value);
		}

		public gameMasterDeviceComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
