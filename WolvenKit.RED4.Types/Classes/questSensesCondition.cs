using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questSensesCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISensesConditionType> Type
		{
			get => GetPropertyValue<CHandle<questISensesConditionType>>();
			set => SetPropertyValue<CHandle<questISensesConditionType>>(value);
		}

		public questSensesCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
