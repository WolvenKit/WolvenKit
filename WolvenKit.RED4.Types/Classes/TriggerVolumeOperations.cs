using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TriggerVolumeOperations : DeviceOperations
	{
		private CArray<STriggerVolumeOperationData> _triggerVolumeOperations;

		[Ordinal(2)] 
		[RED("triggerVolumeOperations")] 
		public CArray<STriggerVolumeOperationData> TriggerVolumeOperations_
		{
			get => GetProperty(ref _triggerVolumeOperations);
			set => SetProperty(ref _triggerVolumeOperations, value);
		}
	}
}
