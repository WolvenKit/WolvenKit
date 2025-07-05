using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questContentCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIContentConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIContentConditionType>>();
			set => SetPropertyValue<CHandle<questIContentConditionType>>(value);
		}

		public questContentCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
