using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SGenericDevicePersistentData : RedBaseClass
	{
		private SGenericDeviceActionsData _genericActions;
		private SCustomDeviceActionsData _customActions;

		[Ordinal(0)] 
		[RED("genericActions")] 
		public SGenericDeviceActionsData GenericActions
		{
			get => GetProperty(ref _genericActions);
			set => SetProperty(ref _genericActions, value);
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
