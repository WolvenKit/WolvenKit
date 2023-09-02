
namespace WolvenKit.RED4.Types
{
	public abstract partial class AISquadMemberBase : ISerializable
	{
		public AISquadMemberBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
