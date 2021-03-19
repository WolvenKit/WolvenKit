using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsRevealObjectEvent : redEvent
	{
		private CBool _reveal;
		private gameVisionModeSystemRevealIdentifier _reason;
		private CFloat _lifetime;

		[Ordinal(0)] 
		[RED("reveal")] 
		public CBool Reveal
		{
			get => GetProperty(ref _reveal);
			set => SetProperty(ref _reveal, value);
		}

		[Ordinal(1)] 
		[RED("reason")] 
		public gameVisionModeSystemRevealIdentifier Reason
		{
			get => GetProperty(ref _reason);
			set => SetProperty(ref _reason, value);
		}

		[Ordinal(2)] 
		[RED("lifetime")] 
		public CFloat Lifetime
		{
			get => GetProperty(ref _lifetime);
			set => SetProperty(ref _lifetime, value);
		}

		public gameeventsRevealObjectEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
