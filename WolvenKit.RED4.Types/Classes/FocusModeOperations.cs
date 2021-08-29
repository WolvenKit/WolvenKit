using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FocusModeOperations : DeviceOperations
	{
		private CArray<SFocusModeOperationData> _focusModeOperations;

		[Ordinal(2)] 
		[RED("focusModeOperations")] 
		public CArray<SFocusModeOperationData> FocusModeOperations_
		{
			get => GetProperty(ref _focusModeOperations);
			set => SetProperty(ref _focusModeOperations, value);
		}
	}
}
