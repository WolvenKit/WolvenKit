using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questFactsDBCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIFactsDBConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIFactsDBConditionType>>();
			set => SetPropertyValue<CHandle<questIFactsDBConditionType>>(value);
		}
	}
}
