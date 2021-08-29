using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DrillerScanEvent : redEvent
	{
		private CBool _newIsScanning;

		[Ordinal(0)] 
		[RED("newIsScanning")] 
		public CBool NewIsScanning
		{
			get => GetProperty(ref _newIsScanning);
			set => SetProperty(ref _newIsScanning, value);
		}
	}
}
