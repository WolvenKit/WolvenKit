using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questEntityCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIEntityConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIEntityConditionType>>();
			set => SetPropertyValue<CHandle<questIEntityConditionType>>(value);
		}
	}
}
