using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AdvanceInteractionStateResolveEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
