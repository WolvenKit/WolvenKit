using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnReserveWorkspotEvent : OnWorkspotAvailabilityEvent
	{
		private CEnum<gamedataWorkspotActionType> _action;

		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<gamedataWorkspotActionType> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}
