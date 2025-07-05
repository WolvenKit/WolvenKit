
namespace WolvenKit.RED4.Types
{
	public partial class IUpdatableSystem : IScriptable
	{
		public IUpdatableSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
