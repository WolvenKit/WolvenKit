using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GenericDeviceActionsData : RedBaseClass
	{
		private SGenericDeviceActionsData _stateActionsOverrides;
		private SCustomDeviceActionsData _customActions;

		[Ordinal(0)] 
		[RED("stateActionsOverrides")] 
		public SGenericDeviceActionsData StateActionsOverrides
		{
			get => GetProperty(ref _stateActionsOverrides);
			set => SetProperty(ref _stateActionsOverrides, value);
		}

		[Ordinal(1)] 
		[RED("customActions")] 
		public SCustomDeviceActionsData CustomActions
		{
			get => GetProperty(ref _customActions);
			set => SetProperty(ref _customActions, value);
		}
	}
}
