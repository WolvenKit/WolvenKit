using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FocusModeOperations : DeviceOperations
	{
		[Ordinal(2)] 
		[RED("focusModeOperations")] 
		public CArray<SFocusModeOperationData> FocusModeOperations_
		{
			get => GetPropertyValue<CArray<SFocusModeOperationData>>();
			set => SetPropertyValue<CArray<SFocusModeOperationData>>(value);
		}

		public FocusModeOperations()
		{
			Components = new();
			FxInstances = new();
			FocusModeOperations_ = new();
		}
	}
}
