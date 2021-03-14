using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ObstacleCollisionLogic : gameuiSideScrollerMiniGameCollisionLogic
	{
		private CBool _hasTriggered;
		private CFloat _invincibityBonusTime;

		[Ordinal(3)] 
		[RED("hasTriggered")] 
		public CBool HasTriggered
		{
			get
			{
				if (_hasTriggered == null)
				{
					_hasTriggered = (CBool) CR2WTypeManager.Create("Bool", "hasTriggered", cr2w, this);
				}
				return _hasTriggered;
			}
			set
			{
				if (_hasTriggered == value)
				{
					return;
				}
				_hasTriggered = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("invincibityBonusTime")] 
		public CFloat InvincibityBonusTime
		{
			get
			{
				if (_invincibityBonusTime == null)
				{
					_invincibityBonusTime = (CFloat) CR2WTypeManager.Create("Float", "invincibityBonusTime", cr2w, this);
				}
				return _invincibityBonusTime;
			}
			set
			{
				if (_invincibityBonusTime == value)
				{
					return;
				}
				_invincibityBonusTime = value;
				PropertySet(this);
			}
		}

		public ObstacleCollisionLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
