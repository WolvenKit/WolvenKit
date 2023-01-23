using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ActivePerkChangedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("perkArea")] 
		public CEnum<gamedataPerkArea> PerkArea
		{
			get => GetPropertyValue<CEnum<gamedataPerkArea>>();
			set => SetPropertyValue<CEnum<gamedataPerkArea>>(value);
		}

		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataPerkType>>();
			set => SetPropertyValue<CEnum<gamedataPerkType>>(value);
		}

		public ActivePerkChangedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
