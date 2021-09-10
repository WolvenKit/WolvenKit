using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecurityGateResponse : redEvent
	{
		[Ordinal(0)] 
		[RED("scanSuccessful")] 
		public CBool ScanSuccessful
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
