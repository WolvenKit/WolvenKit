using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldAISpotNode : worldSocketNode
	{
		[Ordinal(4)] 
		[RED("spot")] 
		public CHandle<AISpot> Spot
		{
			get => GetPropertyValue<CHandle<AISpot>>();
			set => SetPropertyValue<CHandle<AISpot>>(value);
		}

		[Ordinal(5)] 
		[RED("isWorkspotInfinite")] 
		public CBool IsWorkspotInfinite
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("isWorkspotStatic")] 
		public CBool IsWorkspotStatic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(8)] 
		[RED("spotDef")] 
		public CHandle<worldTrafficSpotDefinition> SpotDef
		{
			get => GetPropertyValue<CHandle<worldTrafficSpotDefinition>>();
			set => SetPropertyValue<CHandle<worldTrafficSpotDefinition>>(value);
		}

		[Ordinal(9)] 
		[RED("disableBumps")] 
		public CBool DisableBumps
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("lookAtTarget")] 
		public NodeRef LookAtTarget
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(11)] 
		[RED("useCrowdWhitelist")] 
		public CBool UseCrowdWhitelist
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(12)] 
		[RED("useCrowdBlacklist")] 
		public CBool UseCrowdBlacklist
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("crowdWhitelist")] 
		public redTagList CrowdWhitelist
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(14)] 
		[RED("crowdBlacklist")] 
		public redTagList CrowdBlacklist
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		public worldAISpotNode()
		{
			Markings = new();
			UseCrowdWhitelist = true;
			UseCrowdBlacklist = true;
			CrowdWhitelist = new() { Tags = new() };
			CrowdBlacklist = new() { Tags = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
