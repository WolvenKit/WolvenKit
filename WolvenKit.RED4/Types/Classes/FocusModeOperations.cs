using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
