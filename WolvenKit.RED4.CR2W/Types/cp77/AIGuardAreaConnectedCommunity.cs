using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGuardAreaConnectedCommunity : CVariable
	{
		private gameEntityReference _communityArea;
		private CBool _isPrimary;

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
		[RED("isPrimary")] 
		public CBool IsPrimary
		{
			get
			{
				if (_isPrimary == null)
				{
					_isPrimary = (CBool) CR2WTypeManager.Create("Bool", "isPrimary", cr2w, this);
				}
				return _isPrimary;
			}
			set
			{
				if (_isPrimary == value)
				{
					return;
				}
				_isPrimary = value;
				PropertySet(this);
			}
		}

		public AIGuardAreaConnectedCommunity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
