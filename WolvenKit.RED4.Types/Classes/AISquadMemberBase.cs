
namespace WolvenKit.RED4.Types
{
	public partial class AISquadMemberBase : ISerializable
	{
		public AISquadMemberBase()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
