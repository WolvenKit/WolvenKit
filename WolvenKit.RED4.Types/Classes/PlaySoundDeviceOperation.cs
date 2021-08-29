using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PlaySoundDeviceOperation : DeviceOperationBase
	{
		private CArray<SSFXOperationData> _sFXs;

		[Ordinal(5)] 
		[RED("SFXs")] 
		public CArray<SSFXOperationData> SFXs
		{
			get => GetProperty(ref _sFXs);
			set => SetProperty(ref _sFXs, value);
		}
	}
}
