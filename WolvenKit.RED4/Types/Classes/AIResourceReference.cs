
namespace WolvenKit.RED4.Types
{
	public partial class AIResourceReference : LibTreeCTreeReference
	{
		public AIResourceReference()
		{
			Parameters = new() { Parameters = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
