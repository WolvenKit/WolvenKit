using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CustomActionOperations : DeviceOperations
	{
		private SCustomDeviceActionsData _customActions;
		private CArray<SCustomActionOperationData> _customActionsOperations;

		[Ordinal(2)] 
		[RED("customActions")] 
		public SCustomDeviceActionsData CustomActions
		{
			get => GetProperty(ref _customActions);
			set => SetProperty(ref _customActions, value);
		}

		[Ordinal(3)] 
		[RED("customActionsOperations")] 
		public CArray<SCustomActionOperationData> CustomActionsOperations
		{
			get => GetProperty(ref _customActionsOperations);
			set => SetProperty(ref _customActionsOperations, value);
		}
	}
}
