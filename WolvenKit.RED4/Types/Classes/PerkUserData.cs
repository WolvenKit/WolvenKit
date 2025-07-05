using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkUserData : IScriptable
	{
		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("cyberwareScreenType")] 
		public CEnum<CyberwareScreenType> CyberwareScreenType
		{
			get => GetPropertyValue<CEnum<CyberwareScreenType>>();
			set => SetPropertyValue<CEnum<CyberwareScreenType>>(value);
		}

		[Ordinal(2)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetPropertyValue<CEnum<gamedataNewPerkType>>();
			set => SetPropertyValue<CEnum<gamedataNewPerkType>>(value);
		}

		public PerkUserData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
