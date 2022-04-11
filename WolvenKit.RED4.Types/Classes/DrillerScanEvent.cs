using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DrillerScanEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("newIsScanning")] 
		public CBool NewIsScanning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
