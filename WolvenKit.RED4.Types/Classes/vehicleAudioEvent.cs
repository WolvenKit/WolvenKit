using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleAudioEvent : redEvent
	{
		private CEnum<vehicleAudioEventAction> _action;

		[Ordinal(0)] 
		[RED("action")] 
		public CEnum<vehicleAudioEventAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}
