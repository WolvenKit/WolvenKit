using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class RemoveActiveContextEvent : redEvent
	{
		private CEnum<gamedeviceRequestType> _context;

		[Ordinal(0)] 
		[RED("context")] 
		public CEnum<gamedeviceRequestType> Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}
	}
}
