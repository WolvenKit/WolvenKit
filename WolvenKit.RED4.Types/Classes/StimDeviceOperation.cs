using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class StimDeviceOperation : DeviceOperationBase
	{
		private CArray<SStimOperationData> _stims;

		[Ordinal(5)] 
		[RED("stims")] 
		public CArray<SStimOperationData> Stims
		{
			get => GetProperty(ref _stims);
			set => SetProperty(ref _stims, value);
		}
	}
}
