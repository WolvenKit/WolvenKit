using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameStatDetailedData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("limitMin")] 
		public CFloat LimitMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("limitMax")] 
		public CFloat LimitMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("modifiers")] 
		public CArray<gameStatModifierDetailedData> Modifiers
		{
			get => GetPropertyValue<CArray<gameStatModifierDetailedData>>();
			set => SetPropertyValue<CArray<gameStatModifierDetailedData>>(value);
		}

		[Ordinal(5)] 
		[RED("boolStatType")] 
		public CBool BoolStatType
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameStatDetailedData()
		{
			StatType = Enums.gamedataStatType.Invalid;
			Modifiers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
