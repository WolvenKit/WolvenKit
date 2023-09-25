using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StatPoolPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetPropertyValue<CEnum<gamedataStatPoolType>>();
			set => SetPropertyValue<CEnum<gamedataStatPoolType>>(value);
		}

		[Ordinal(1)] 
		[RED("valueToCheck")] 
		public CArray<CWeakHandle<gamedataStatModifier_Record>> ValueToCheck
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataStatModifier_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataStatModifier_Record>>>(value);
		}

		[Ordinal(2)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		[Ordinal(3)] 
		[RED("skipOnApply")] 
		public CBool SkipOnApply
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("comparePercentage")] 
		public CBool ComparePercentage
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("objToCheck")] 
		public CEnum<ObjectToCheck> ObjToCheck
		{
			get => GetPropertyValue<CEnum<ObjectToCheck>>();
			set => SetPropertyValue<CEnum<ObjectToCheck>>(value);
		}

		public StatPoolPrereq()
		{
			ValueToCheck = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
