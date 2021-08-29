using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questStatsCondition : questTypedCondition
	{
		private CHandle<questIStatsConditionType> _type;

		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIStatsConditionType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
