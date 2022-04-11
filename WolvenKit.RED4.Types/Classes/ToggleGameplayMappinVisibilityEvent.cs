using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ToggleGameplayMappinVisibilityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
