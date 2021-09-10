using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TriggerVolumeOperations : DeviceOperations
	{
		[Ordinal(2)] 
		[RED("triggerVolumeOperations")] 
		public CArray<STriggerVolumeOperationData> TriggerVolumeOperations_
		{
			get => GetPropertyValue<CArray<STriggerVolumeOperationData>>();
			set => SetPropertyValue<CArray<STriggerVolumeOperationData>>(value);
		}

		public TriggerVolumeOperations()
		{
			Components = new();
			FxInstances = new();
			TriggerVolumeOperations_ = new();
		}
	}
}
