using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkUnlockedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		public NewPerkUnlockedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
