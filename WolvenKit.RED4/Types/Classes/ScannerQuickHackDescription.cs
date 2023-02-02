using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerQuickHackDescription : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("QuickHackDescription")] 
		public CHandle<QuickhackData> QuickHackDescription
		{
			get => GetPropertyValue<CHandle<QuickhackData>>();
			set => SetPropertyValue<CHandle<QuickhackData>>(value);
		}

		public ScannerQuickHackDescription()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
