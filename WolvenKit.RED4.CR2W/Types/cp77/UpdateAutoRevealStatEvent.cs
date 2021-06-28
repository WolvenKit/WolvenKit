using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpdateAutoRevealStatEvent : redEvent
	{
		private CBool _hasAutoReveal;

		[Ordinal(0)] 
		[RED("hasAutoReveal")] 
		public CBool HasAutoReveal
		{
			get => GetProperty(ref _hasAutoReveal);
			set => SetProperty(ref _hasAutoReveal, value);
		}

		public UpdateAutoRevealStatEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
