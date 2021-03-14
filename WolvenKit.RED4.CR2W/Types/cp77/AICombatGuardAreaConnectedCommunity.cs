using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICombatGuardAreaConnectedCommunity : CVariable
	{
		private gameEntityReference _communityArea;
		private CArray<CHandle<AIICombatGuardAreaCondition>> _conditions;

		[Ordinal(0)] 
		[RED("communityArea")] 
		public gameEntityReference CommunityArea
		{
			get
			{
				if (_communityArea == null)
				{
					_communityArea = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "communityArea", cr2w, this);
				}
				return _communityArea;
			}
			set
			{
				if (_communityArea == value)
				{
					return;
				}
				_communityArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<AIICombatGuardAreaCondition>> Conditions
		{
			get
			{
				if (_conditions == null)
				{
					_conditions = (CArray<CHandle<AIICombatGuardAreaCondition>>) CR2WTypeManager.Create("array:handle:AIICombatGuardAreaCondition", "conditions", cr2w, this);
				}
				return _conditions;
			}
			set
			{
				if (_conditions == value)
				{
					return;
				}
				_conditions = value;
				PropertySet(this);
			}
		}

		public AICombatGuardAreaConnectedCommunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
