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
			get => GetProperty(ref _started);
			set => SetProperty(ref _started, value);
		}

		public gameeventsSquadStartedCombatEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
