using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetIsSpiderbotInteractionOrderedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
