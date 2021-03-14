using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiAccessPointMiniGameStatus : redEvent
	{
		private CEnum<gameuiHackingMinigameState> _minigameState;

		[Ordinal(0)] 
		[RED("minigameState")] 
		public CEnum<gameuiHackingMinigameState> MinigameState
		{
			get
			{
				if (_minigameState == null)
				{
					_minigameState = (CEnum<gameuiHackingMinigameState>) CR2WTypeManager.Create("gameuiHackingMinigameState", "minigameState", cr2w, this);
				}
				return _minigameState;
			}
			set
			{
				if (_minigameState == value)
				{
					return;
				}
				_minigameState = value;
				PropertySet(this);
			}
		}

		public gameuiAccessPointMiniGameStatus(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
