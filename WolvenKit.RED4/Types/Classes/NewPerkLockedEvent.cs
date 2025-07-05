using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkLockedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		public NewPerkLockedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
