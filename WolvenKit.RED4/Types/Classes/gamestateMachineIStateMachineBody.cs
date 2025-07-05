
namespace WolvenKit.RED4.Types
{
	public abstract partial class gamestateMachineIStateMachineBody : ISerializable
	{
		public gamestateMachineIStateMachineBody()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
