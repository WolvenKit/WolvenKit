using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TogglePersonalLink : ActionBool
	{
		private CEnum<EPersonalLinkConnectionStatus> _cachedStatus;
		private CBool _shouldSkipMiniGame;

		[Ordinal(25)] 
		[RED("cachedStatus")] 
		public CEnum<EPersonalLinkConnectionStatus> CachedStatus
		{
			get
			{
				if (_cachedStatus == null)
				{
					_cachedStatus = (CEnum<EPersonalLinkConnectionStatus>) CR2WTypeManager.Create("EPersonalLinkConnectionStatus", "cachedStatus", cr2w, this);
				}
				return _cachedStatus;
			}
			set
			{
				if (_cachedStatus == value)
				{
					return;
				}
				_cachedStatus = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("shouldSkipMiniGame")] 
		public CBool ShouldSkipMiniGame
		{
			get
			{
				if (_shouldSkipMiniGame == null)
				{
					_shouldSkipMiniGame = (CBool) CR2WTypeManager.Create("Bool", "shouldSkipMiniGame", cr2w, this);
				}
				return _shouldSkipMiniGame;
			}
			set
			{
				if (_shouldSkipMiniGame == value)
				{
					return;
				}
				_shouldSkipMiniGame = value;
				PropertySet(this);
			}
		}

		public TogglePersonalLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
