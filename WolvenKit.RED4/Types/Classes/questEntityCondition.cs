using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIEntityConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIEntityConditionType>>();
			set => SetPropertyValue<CHandle<questIEntityConditionType>>(value);
		}

		public questEntityCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
