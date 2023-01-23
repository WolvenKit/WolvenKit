using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_WorkspotAnim : animAnimNode_Base
	{
		[Ordinal(11)] 
		[RED("collectEvents")] 
		public CBool CollectEvents
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("inputLink")] 
		public animPoseLink InputLink
		{
			get => GetPropertyValue<animPoseLink>();
			set => SetPropertyValue<animPoseLink>(value);
		}

		public animAnimNode_WorkspotAnim()
		{
			Id = 4294967295;
			CollectEvents = true;
			InputLink = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
