
namespace WolvenKit.RED4.Types
{
	public abstract partial class gsmMenuState : gsmState
	{
		public gsmMenuState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
