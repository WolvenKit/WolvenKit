using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVisionRevealExpiredEvent : redEvent
	{
		private gameVisionModeSystemRevealIdentifier _revealId;

		[Ordinal(0)] 
		[RED("revealId")] 
		public gameVisionModeSystemRevealIdentifier RevealId
		{
			get
			{
				if (_revealId == null)
				{
					_revealId = (gameVisionModeSystemRevealIdentifier) CR2WTypeManager.Create("gameVisionModeSystemRevealIdentifier", "revealId", cr2w, this);
				}
				return _revealId;
			}
			set
			{
				if (_revealId == value)
				{
					return;
				}
				_revealId = value;
				PropertySet(this);
			}
		}

		public gameVisionRevealExpiredEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
