
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkStateMachine : inkIStateMachine
	{
		public inkStateMachine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
