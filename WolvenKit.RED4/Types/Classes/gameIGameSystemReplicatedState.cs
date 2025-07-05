
namespace WolvenKit.RED4.Types
{
	public abstract partial class gameIGameSystemReplicatedState : ISerializable
	{
		public gameIGameSystemReplicatedState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
