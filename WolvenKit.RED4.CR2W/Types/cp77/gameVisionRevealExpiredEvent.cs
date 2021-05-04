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
			get => GetProperty(ref _revealId);
			set => SetProperty(ref _revealId, value);
		}

		public gameVisionRevealExpiredEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
