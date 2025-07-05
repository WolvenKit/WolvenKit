using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questDynamicSpawnSystemCondition : questTypedCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CHandle<questIDynamicSpawnSystemConditionType> Type
		{
			get => GetPropertyValue<CHandle<questIDynamicSpawnSystemConditionType>>();
			set => SetPropertyValue<CHandle<questIDynamicSpawnSystemConditionType>>(value);
		}

		public questDynamicSpawnSystemCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
