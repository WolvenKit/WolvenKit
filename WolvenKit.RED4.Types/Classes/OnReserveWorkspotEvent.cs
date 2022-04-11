using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OnReserveWorkspotEvent : OnWorkspotAvailabilityEvent
	{
		[Ordinal(1)] 
		[RED("action")] 
		public CEnum<gamedataWorkspotActionType> Action
		{
			get => GetPropertyValue<CEnum<gamedataWorkspotActionType>>();
			set => SetPropertyValue<CEnum<gamedataWorkspotActionType>>(value);
		}
	}
}
