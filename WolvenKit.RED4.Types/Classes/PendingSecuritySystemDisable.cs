using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PendingSecuritySystemDisable : redEvent
	{
		[Ordinal(0)] 
		[RED("isPending")] 
		public CBool IsPending
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
