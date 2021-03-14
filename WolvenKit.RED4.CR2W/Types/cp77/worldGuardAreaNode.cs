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
			get
			{
				if (_communityEntries == null)
				{
					_communityEntries = (CArray<AIGuardAreaConnectedCommunity>) CR2WTypeManager.Create("array:AIGuardAreaConnectedCommunity", "communityEntries", cr2w, this);
				}
				return _communityEntries;
			}
			set
			{
				if (_communityEntries == value)
				{
					return;
				}
				_communityEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("combatCommunityEntries")] 
		public CArray<AICombatGuardAreaConnectedCommunity> CombatCommunityEntries
		{
			get
			{
				if (_combatCommunityEntries == null)
				{
					_combatCommunityEntries = (CArray<AICombatGuardAreaConnectedCommunity>) CR2WTypeManager.Create("array:AICombatGuardAreaConnectedCommunity", "combatCommunityEntries", cr2w, this);
				}
				return _combatCommunityEntries;
			}
			set
			{
				if (_combatCommunityEntries == value)
				{
					return;
				}
				_combatCommunityEntries = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("pursuitArea")] 
		public NodeRef PursuitArea
		{
			get
			{
				if (_pursuitArea == null)
				{
					_pursuitArea = (NodeRef) CR2WTypeManager.Create("NodeRef", "pursuitArea", cr2w, this);
				}
				return _pursuitArea;
			}
			set
			{
				if (_pursuitArea == value)
				{
					return;
				}
				_pursuitArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("pursuitRange")] 
		public CFloat PursuitRange
		{
			get
			{
				if (_pursuitRange == null)
				{
					_pursuitRange = (CFloat) CR2WTypeManager.Create("Float", "pursuitRange", cr2w, this);
				}
				return _pursuitRange;
			}
			set
			{
				if (_pursuitRange == value)
				{
					return;
				}
				_pursuitRange = value;
				PropertySet(this);
			}
		}

		public worldGuardAreaNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
