using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCrowdMemberComponent : entIComponent
	{
		[Ordinal(3)] 
		[RED("forceCrowdToIgnore")] 
		public CBool ForceCrowdToIgnore
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameCrowdMemberComponent()
		{
			Name = "CrowdMember";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
