
namespace WolvenKit.RED4.Types
{
	public partial class ShardCaseContainerPS : gameLootContainerBasePS
	{
		public ShardCaseContainerPS()
		{
			MarkAsQuest = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
