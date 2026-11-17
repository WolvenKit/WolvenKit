
namespace WolvenKit.RED4.Types
{
	public partial class AIResourceReference : LibTreeCTreeReference
	{
		public AIResourceReference()
		{
			Parameters = new LibTreeParameterList();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
