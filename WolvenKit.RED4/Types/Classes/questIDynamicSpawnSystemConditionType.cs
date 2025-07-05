
namespace WolvenKit.RED4.Types
{
	public abstract partial class questIDynamicSpawnSystemConditionType : questIConditionType
	{
		public questIDynamicSpawnSystemConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
