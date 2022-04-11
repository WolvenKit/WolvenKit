using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class netEntityAttachmentInterface : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("time")] 
		public netTime Time
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public netEntityAttachmentInterface()
		{
			Time = new() { MilliSecs = 18446744073709551615 };
		}
	}
}
