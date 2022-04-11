using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSpawnerCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questISpawnerConditionType> Type
		{
			get => GetPropertyValue<CHandle<questISpawnerConditionType>>();
			set => SetPropertyValue<CHandle<questISpawnerConditionType>>(value);
		}
	}
}
