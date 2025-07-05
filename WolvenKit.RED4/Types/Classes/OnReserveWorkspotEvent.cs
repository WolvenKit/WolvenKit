using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnReserveWorkspotEvent : OnWorkspotAvailabilityEvent
	{
		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<gamedataWorkspotActionType> Action
		{
			get => GetPropertyValue<CEnum<gamedataWorkspotActionType>>();
			set => SetPropertyValue<CEnum<gamedataWorkspotActionType>>(value);
		}

		public OnReserveWorkspotEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
