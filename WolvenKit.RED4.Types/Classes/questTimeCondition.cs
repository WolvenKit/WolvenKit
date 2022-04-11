using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTimeCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questITimeConditionType> Type
		{
			get => GetPropertyValue<CHandle<questITimeConditionType>>();
			set => SetPropertyValue<CHandle<questITimeConditionType>>(value);
		}
	}
}
