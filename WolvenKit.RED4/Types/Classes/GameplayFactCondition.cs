using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayFactCondition : GameplayConditionBase
	{
		[Ordinal(1)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("value")] 
		public CInt32 Value
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<ECompareOp> ComparisonType
		{
			get => GetPropertyValue<CEnum<ECompareOp>>();
			set => SetPropertyValue<CEnum<ECompareOp>>(value);
		}

		[Ordinal(4)] 
		[RED("description")] 
		public CString Description
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public GameplayFactCondition()
		{
			EntityID = new entEntityID();
			Description = "Quest progress";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
