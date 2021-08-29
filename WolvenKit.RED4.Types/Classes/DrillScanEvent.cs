using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DrillScanEvent : redEvent
	{
		private CBool _isScanning;

		[Ordinal(0)] 
		[RED("IsScanning")] 
		public CBool IsScanning
		{
			get => GetProperty(ref _isScanning);
			set => SetProperty(ref _isScanning, value);
		}
	}
}
