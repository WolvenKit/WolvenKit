using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePrereqCheckData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("prereqType")] 
		public CEnum<gameEPrerequisiteType> PrereqType
		{
			get => GetPropertyValue<CEnum<gameEPrerequisiteType>>();
			set => SetPropertyValue<CEnum<gameEPrerequisiteType>>(value);
		}

		[Ordinal(1)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetPropertyValue<CEnum<EComparisonType>>();
			set => SetPropertyValue<CEnum<EComparisonType>>(value);
		}

		[Ordinal(2)] 
		[RED("contextObject")] 
		public CString ContextObject
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("valueToCompare")] 
		public CFloat ValueToCompare
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gamePrereqCheckData()
		{
			ComparisonType = Enums.EComparisonType.Equal;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
