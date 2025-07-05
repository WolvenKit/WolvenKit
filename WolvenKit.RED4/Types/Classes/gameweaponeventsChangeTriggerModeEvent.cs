using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameweaponeventsChangeTriggerModeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("triggerMode")] 
		public CEnum<gamedataTriggerMode> TriggerMode
		{
			get => GetPropertyValue<CEnum<gamedataTriggerMode>>();
			set => SetPropertyValue<CEnum<gamedataTriggerMode>>(value);
		}

		public gameweaponeventsChangeTriggerModeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
