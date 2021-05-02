using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivateCoverEvents : CoverActionEventsTransition
	{
		private CBool _usingCover;

		[Ordinal(0)] 
		[RED("usingCover")] 
		public CBool UsingCover
		{
			get => GetProperty(ref _usingCover);
			set => SetProperty(ref _usingCover, value);
		}

		public ActivateCoverEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
