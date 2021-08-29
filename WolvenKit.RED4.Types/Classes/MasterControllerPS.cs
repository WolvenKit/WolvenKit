using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MasterControllerPS : ScriptableDeviceComponentPS
	{
		private CHandle<gamedeviceClearance> _clearance;

		[Ordinal(104)] 
		[RED("clearance")] 
		public CHandle<gamedeviceClearance> Clearance
		{
			get => GetProperty(ref _clearance);
			set => SetProperty(ref _clearance, value);
		}
	}
}
