using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerTargetChangedRequest : gameScriptableSystemRequest
	{
		private entEntityID _scannerTarget;

		[Ordinal(0)] 
		[RED("scannerTarget")] 
		public entEntityID ScannerTarget
		{
			get => GetProperty(ref _scannerTarget);
			set => SetProperty(ref _scannerTarget, value);
		}
	}
}
