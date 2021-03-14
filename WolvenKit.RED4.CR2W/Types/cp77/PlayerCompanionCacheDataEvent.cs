using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerCompanionCacheDataEvent : redEvent
	{
		private CBool _isPlayerCompanionCached;
		private CFloat _isPlayerCompanionCachedTimeStamp;

		[Ordinal(0)] 
		[RED("isPlayerCompanionCached")] 
		public CBool IsPlayerCompanionCached
		{
			get
			{
				if (_isPlayerCompanionCached == null)
				{
					_isPlayerCompanionCached = (CBool) CR2WTypeManager.Create("Bool", "isPlayerCompanionCached", cr2w, this);
				}
				return _isPlayerCompanionCached;
			}
			set
			{
				if (_isPlayerCompanionCached == value)
				{
					return;
				}
				_isPlayerCompanionCached = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isPlayerCompanionCachedTimeStamp")] 
		public CFloat IsPlayerCompanionCachedTimeStamp
		{
			get
			{
				if (_isPlayerCompanionCachedTimeStamp == null)
				{
					_isPlayerCompanionCachedTimeStamp = (CFloat) CR2WTypeManager.Create("Float", "isPlayerCompanionCachedTimeStamp", cr2w, this);
				}
				return _isPlayerCompanionCachedTimeStamp;
			}
			set
			{
				if (_isPlayerCompanionCachedTimeStamp == value)
				{
					return;
				}
				_isPlayerCompanionCachedTimeStamp = value;
				PropertySet(this);
			}
		}

		public PlayerCompanionCacheDataEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
