using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questObjectCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIObjectConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIObjectConditionType>>();
			set => SetPropertyValue<CHandle<questIObjectConditionType>>(value);
		}
	}
}
