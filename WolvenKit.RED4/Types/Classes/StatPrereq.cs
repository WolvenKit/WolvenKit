using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("notifyOnAnyChange")] 
		public CBool NotifyOnAnyChange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("notifyOnlyOnStateFulfilled")] 
		public CBool NotifyOnlyOnStateFulfilled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(3)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		[Ordinal(5)] 
		[RED("statModifiersUsed")] 
		public CBool StatModifiersUsed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("statPrereqRecordID")] 
		public TweakDBID StatPrereqRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(7)] 
		[RED("objToCheck")] 
		public CName ObjToCheck
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public StatPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
