using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCombinedStatModifierData_Deprecated : gameStatModifierData_Deprecated
	{
		[Ordinal(2)] 
		[RED("refStatType")] 
		public CEnum<gamedataStatType> RefStatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(3)] 
		[RED("operation")] 
		public CEnum<gameCombinedStatOperation> Operation
		{
			get => GetPropertyValue<CEnum<gameCombinedStatOperation>>();
			set => SetPropertyValue<CEnum<gameCombinedStatOperation>>(value);
		}

		[Ordinal(4)] 
		[RED("refObject")] 
		public CEnum<gameStatObjectsRelation> RefObject
		{
			get => GetPropertyValue<CEnum<gameStatObjectsRelation>>();
			set => SetPropertyValue<CEnum<gameStatObjectsRelation>>(value);
		}

		[Ordinal(5)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameCombinedStatModifierData_Deprecated()
		{
			StatType = Enums.gamedataStatType.Invalid;
			ModifierType = Enums.gameStatModifierType.Invalid;
			RefStatType = Enums.gamedataStatType.Invalid;
			Operation = Enums.gameCombinedStatOperation.Invalid;
			RefObject = Enums.gameStatObjectsRelation.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
