using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsObjectMarkerVisibilityUpdated : redEvent
	{
		[Ordinal(0)] 
		[RED("canHaveObjectMarker")] 
		public CBool CanHaveObjectMarker
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
