
namespace WolvenKit.RED4.Types
{
	public abstract partial class worldSocketNode : worldNode
	{
		public worldSocketNode()
		{
			IsVisibleInGame = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
