using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsSquadStartedCombatEvent : redEvent
	{
		private CBool _started;

		[Ordinal(0)] 
		[RED("started")] 
		public CBool Started
		{
			get
			{
				if (_started == null)
				{
					_started = (CBool) CR2WTypeManager.Create("Bool", "started", cr2w, this);
				}
				return _started;
			}
			set
			{
				if (_started == value)
				{
					return;
				}
				_started = value;
				PropertySet(this);
			}
		}

		public gameeventsSquadStartedCombatEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
