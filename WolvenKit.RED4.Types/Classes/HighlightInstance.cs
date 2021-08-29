using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class HighlightInstance : ModuleInstance
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
	}
}
