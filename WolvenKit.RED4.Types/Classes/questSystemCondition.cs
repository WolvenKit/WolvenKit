using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSystemCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISystemConditionType> Type
		{
			get => GetPropertyValue<CHandle<questISystemConditionType>>();
			set => SetPropertyValue<CHandle<questISystemConditionType>>(value);
		}
	}
}
