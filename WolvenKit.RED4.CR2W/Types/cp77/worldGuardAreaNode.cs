using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldGuardAreaNode : worldAreaShapeNode
	{
		private CArray<AIGuardAreaConnectedCommunity> _communityEntries;
		private CArray<AICombatGuardAreaConnectedCommunity> _combatCommunityEntries;
		private NodeRef _pursuitArea;
		private CFloat _pursuitRange;

		[Ordinal(6)] 
		[RED("communityEntries")] 
		public CArray<AIGuardAreaConnectedCommunity> CommunityEntries
		{
			get => GetProperty(ref _communityEntries);
			set => SetProperty(ref _communityEntries, value);
		}

		[Ordinal(7)] 
		[RED("combatCommunityEntries")] 
		public CArray<AICombatGuardAreaConnectedCommunity> CombatCommunityEntries
		{
			get => GetProperty(ref _combatCommunityEntries);
			set => SetProperty(ref _combatCommunityEntries, value);
		}

		[Ordinal(8)] 
		[RED("pursuitArea")] 
		public NodeRef PursuitArea
		{
			get => GetProperty(ref _pursuitArea);
			set => SetProperty(ref _pursuitArea, value);
		}

		[Ordinal(9)] 
		[RED("pursuitRange")] 
		public CFloat PursuitRange
		{
			get => GetProperty(ref _pursuitRange);
			set => SetProperty(ref _pursuitRange, value);
		}

		public worldGuardAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
