using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerTargetChangedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("scannerTarget")] 
		public entEntityID ScannerTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public ScannerTargetChangedRequest()
		{
			ScannerTarget = new();
		}
	}
}
