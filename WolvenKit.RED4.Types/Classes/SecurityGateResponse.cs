using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityGateResponse : redEvent
	{
		private CBool _scanSuccessful;

		[Ordinal(0)] 
		[RED("scanSuccessful")] 
		public CBool ScanSuccessful
		{
			get => GetProperty(ref _scanSuccessful);
			set => SetProperty(ref _scanSuccessful, value);
		}
	}
}
