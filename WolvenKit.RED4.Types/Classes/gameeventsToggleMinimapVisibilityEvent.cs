using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsToggleMinimapVisibilityEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("show")] 
		public CBool Show
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
