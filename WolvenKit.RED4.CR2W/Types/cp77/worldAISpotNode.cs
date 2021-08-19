using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldAISpotNode : worldSocketNode
	{
		private CHandle<AISpot> _spot;
		private CBool _isWorkspotInfinite;
		private CBool _isWorkspotStatic;
		private CArray<CName> _markings;
		private CHandle<worldTrafficSpotDefinition> _spotDef;
		private CBool _disableBumps;
		private NodeRef _lookAtTarget;
		private CBool _useCrowdWhitelist;
		private CBool _useCrowdBlacklist;
		private redTagList _crowdWhitelist;
		private redTagList _crowdBlacklist;

		[Ordinal(4)] 
		[RED("spot")] 
		public CHandle<AISpot> Spot
		{
			get => GetProperty(ref _spot);
			set => SetProperty(ref _spot, value);
		}

		[Ordinal(5)] 
		[RED("isWorkspotInfinite")] 
		public CBool IsWorkspotInfinite
		{
			get => GetProperty(ref _isWorkspotInfinite);
			set => SetProperty(ref _isWorkspotInfinite, value);
		}

		[Ordinal(6)] 
		[RED("isWorkspotStatic")] 
		public CBool IsWorkspotStatic
		{
			get => GetProperty(ref _isWorkspotStatic);
			set => SetProperty(ref _isWorkspotStatic, value);
		}

		[Ordinal(7)] 
		[RED("markings")] 
		public CArray<CName> Markings
		{
			get => GetProperty(ref _markings);
			set => SetProperty(ref _markings, value);
		}

		[Ordinal(8)] 
		[RED("spotDef")] 
		public CHandle<worldTrafficSpotDefinition> SpotDef
		{
			get => GetProperty(ref _spotDef);
			set => SetProperty(ref _spotDef, value);
		}

		[Ordinal(9)] 
		[RED("disableBumps")] 
		public CBool DisableBumps
		{
			get => GetProperty(ref _disableBumps);
			set => SetProperty(ref _disableBumps, value);
		}

		[Ordinal(10)] 
		[RED("lookAtTarget")] 
		public NodeRef LookAtTarget
		{
			get => GetProperty(ref _lookAtTarget);
			set => SetProperty(ref _lookAtTarget, value);
		}

		[Ordinal(11)] 
		[RED("useCrowdWhitelist")] 
		public CBool UseCrowdWhitelist
		{
			get => GetProperty(ref _useCrowdWhitelist);
			set => SetProperty(ref _useCrowdWhitelist, value);
		}

		[Ordinal(12)] 
		[RED("useCrowdBlacklist")] 
		public CBool UseCrowdBlacklist
		{
			get => GetProperty(ref _useCrowdBlacklist);
			set => SetProperty(ref _useCrowdBlacklist, value);
		}

		[Ordinal(13)] 
		[RED("crowdWhitelist")] 
		public redTagList CrowdWhitelist
		{
			get => GetProperty(ref _crowdWhitelist);
			set => SetProperty(ref _crowdWhitelist, value);
		}

		[Ordinal(14)] 
		[RED("crowdBlacklist")] 
		public redTagList CrowdBlacklist
		{
			get => GetProperty(ref _crowdBlacklist);
			set => SetProperty(ref _crowdBlacklist, value);
		}

		public worldAISpotNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
