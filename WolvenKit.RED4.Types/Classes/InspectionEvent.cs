using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InspectionEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
