using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HighlightInstance : ModuleInstance
	{
		private CEnum<HighlightContext> _context;
		private CBool _instant;

		[Ordinal(6)] 
		[RED("context")] 
		public CEnum<HighlightContext> Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		[Ordinal(7)] 
		[RED("instant")] 
		public CBool Instant
		{
			get => GetProperty(ref _instant);
			set => SetProperty(ref _instant, value);
		}

		public HighlightInstance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
