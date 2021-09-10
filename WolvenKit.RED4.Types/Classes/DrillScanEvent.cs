using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DrillScanEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("IsScanning")] 
		public CBool IsScanning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
