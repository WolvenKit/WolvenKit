using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SecuritySystemSupport : redEvent
	{
		[Ordinal(0)] 
		[RED("supportGranted")] 
		public CBool SupportGranted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
