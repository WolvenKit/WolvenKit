using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MasterControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(104)] 
		[RED("clearance")] 
		public CHandle<gamedeviceClearance> Clearance
		{
			get => GetPropertyValue<CHandle<gamedeviceClearance>>();
			set => SetPropertyValue<CHandle<gamedeviceClearance>>(value);
		}
	}
}
