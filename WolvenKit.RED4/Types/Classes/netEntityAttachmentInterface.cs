using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			Time = new netTime { MilliSecs = long.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
