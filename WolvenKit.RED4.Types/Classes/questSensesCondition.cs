using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSensesCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISensesConditionType> Type
		{
			get => GetPropertyValue<CHandle<questISensesConditionType>>();
			set => SetPropertyValue<CHandle<questISensesConditionType>>(value);
		}
	}
}
