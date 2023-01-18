using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MasterControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("clearance")] 
		public CHandle<gamedeviceClearance> Clearance
		{
			get => GetPropertyValue<CHandle<gamedeviceClearance>>();
			set => SetPropertyValue<CHandle<gamedeviceClearance>>(value);
		}

		public MasterControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
