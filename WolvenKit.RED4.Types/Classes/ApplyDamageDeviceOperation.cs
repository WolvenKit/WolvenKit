using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApplyDamageDeviceOperation : DeviceOperationBase
	{
		private CArray<SDamageOperationData> _damages;

		[Ordinal(5)] 
		[RED("damages")] 
		public CArray<SDamageOperationData> Damages
		{
			get => GetProperty(ref _damages);
			set => SetProperty(ref _damages, value);
		}
	}
}
