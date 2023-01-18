using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questStatsCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIStatsConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIStatsConditionType>>();
			set => SetPropertyValue<CHandle<questIStatsConditionType>>(value);
		}

		public questStatsCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
