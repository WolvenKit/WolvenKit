using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCurveStatModifierData_Deprecated : gameStatModifierData_Deprecated
	{
		[Ordinal(2)] 
		[RED("curveName")] 
		public CName CurveName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("columnName")] 
		public CName ColumnName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("curveStat")] 
		public CEnum<gamedataStatType> CurveStat
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		public gameCurveStatModifierData_Deprecated()
		{
			StatType = Enums.gamedataStatType.Invalid;
			ModifierType = Enums.gameStatModifierType.Invalid;
			CurveStat = Enums.gamedataStatType.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
