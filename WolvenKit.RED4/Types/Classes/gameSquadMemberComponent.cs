
namespace WolvenKit.RED4.Types
{
	public partial class gameSquadMemberComponent : gameComponent
	{
		public gameSquadMemberComponent()
		{
			Name = "SquadMember";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
