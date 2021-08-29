using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netEntityAttachmentInterface : RedBaseClass
	{
		private netTime _time;

		[Ordinal(0)] 
		[RED("time")] 
		public netTime Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}
	}
}
