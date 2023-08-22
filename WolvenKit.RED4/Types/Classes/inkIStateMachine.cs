
namespace WolvenKit.RED4.Types
{
	public abstract partial class inkIStateMachine : ISerializable
	{
		public inkIStateMachine()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
