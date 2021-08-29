using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiRequestPushContextEvent : redEvent
	{
		private CEnum<UIGameContext> _context;

		[Ordinal(0)] 
		[RED("context")] 
		public CEnum<UIGameContext> Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}
	}
}
