using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScanEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("clue")] 
		public CString Clue
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("isAvailable")] 
		public CBool IsAvailable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScanEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
