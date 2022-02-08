using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetBountyAwardedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("awarded")] 
		public CBool Awarded
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
