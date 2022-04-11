using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questUICondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIUIConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIUIConditionType>>();
			set => SetPropertyValue<CHandle<questIUIConditionType>>(value);
		}
	}
}
