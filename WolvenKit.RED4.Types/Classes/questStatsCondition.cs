using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStatsCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIStatsConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIStatsConditionType>>();
			set => SetPropertyValue<CHandle<questIStatsConditionType>>(value);
		}
	}
}
