using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HidePuppetDelayEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("target")] 
		public CWeakHandle<NPCPuppet> Target
		{
			get => GetPropertyValue<CWeakHandle<NPCPuppet>>();
			set => SetPropertyValue<CWeakHandle<NPCPuppet>>(value);
		}

		public HidePuppetDelayEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
