using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewPerkSoldEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		[Ordinal(1)] 
		[RED("perkLevelSold")] 
		public CInt32 PerkLevelSold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public NewPerkSoldEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
