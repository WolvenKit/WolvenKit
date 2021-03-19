using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetQuickHackAttemptEvent : redEvent
	{
		private CBool _wasQuickHackAttempt;

		[Ordinal(0)] 
		[RED("wasQuickHackAttempt")] 
		public CBool WasQuickHackAttempt
		{
			get => GetProperty(ref _wasQuickHackAttempt);
			set => SetProperty(ref _wasQuickHackAttempt, value);
		}

		public SetQuickHackAttemptEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
