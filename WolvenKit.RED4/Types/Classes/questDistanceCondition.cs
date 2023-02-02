using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDistanceCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIDistanceConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIDistanceConditionType>>();
			set => SetPropertyValue<CHandle<questIDistanceConditionType>>(value);
		}

		public questDistanceCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
