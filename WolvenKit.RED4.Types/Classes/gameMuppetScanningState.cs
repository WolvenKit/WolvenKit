using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetScanningState : RedBaseClass
	{
		private CBool _isScanning;

		[Ordinal(0)] 
		[RED("isScanning")] 
		public CBool IsScanning
		{
			get => GetProperty(ref _isScanning);
			set => SetProperty(ref _isScanning, value);
		}
	}
}
