using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsKillRewardEvent : redEvent
	{
		private wCHandle<gameObject> _victim;
		private CEnum<gameKillType> _killType;

		[Ordinal(0)] 
		[RED("victim")] 
		public wCHandle<gameObject> Victim
		{
			get => GetProperty(ref _victim);
			set => SetProperty(ref _victim, value);
		}

		[Ordinal(1)] 
		[RED("killType")] 
		public CEnum<gameKillType> KillType
		{
			get => GetProperty(ref _killType);
			set => SetProperty(ref _killType, value);
		}

		public gameeventsKillRewardEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
