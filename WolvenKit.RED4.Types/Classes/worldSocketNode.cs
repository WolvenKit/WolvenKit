
namespace WolvenKit.RED4.Types
{
	public partial class worldSocketNode : worldNode
	{
		public worldSocketNode()
		{
			IsVisibleInGame = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
