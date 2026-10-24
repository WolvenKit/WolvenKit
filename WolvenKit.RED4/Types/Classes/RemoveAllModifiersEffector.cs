using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveAllModifiersEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("targets")] 
		public CArray<gameStatsObjectID> Targets
		{
			get => GetPropertyValue<CArray<gameStatsObjectID>>();
			set => SetPropertyValue<CArray<gameStatsObjectID>>(value);
		}

		public RemoveAllModifiersEffector()
		{
			Targets = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
