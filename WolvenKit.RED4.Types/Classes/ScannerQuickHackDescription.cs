using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerQuickHackDescription : ScannerChunk
	{
		private CHandle<QuickhackData> _quickHackDescription;

		[Ordinal(0)] 
		[RED("QuickHackDescription")] 
		public CHandle<QuickhackData> QuickHackDescription
		{
			get => GetProperty(ref _quickHackDescription);
			set => SetProperty(ref _quickHackDescription, value);
		}
	}
}
