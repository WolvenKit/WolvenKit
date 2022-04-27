
namespace WolvenKit.RED4.Types
{
	public partial class gameCrowdMemberComponent : entIComponent
	{
		public gameCrowdMemberComponent()
		{
			Name = "CrowdMember";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
