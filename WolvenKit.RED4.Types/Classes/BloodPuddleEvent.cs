using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BloodPuddleEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("cyberBlood")] 
		public CBool CyberBlood
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public BloodPuddleEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
