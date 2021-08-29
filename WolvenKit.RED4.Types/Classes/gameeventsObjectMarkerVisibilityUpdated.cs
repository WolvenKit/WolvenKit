using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameeventsObjectMarkerVisibilityUpdated : redEvent
	{
		private CBool _canHaveObjectMarker;
		private CBool _isVisible;

		[Ordinal(0)] 
		[RED("canHaveObjectMarker")] 
		public CBool CanHaveObjectMarker
		{
			get => GetProperty(ref _canHaveObjectMarker);
			set => SetProperty(ref _canHaveObjectMarker, value);
		}

		[Ordinal(1)] 
		[RED("isVisible")] 
		public CBool IsVisible
		{
			get => GetProperty(ref _isVisible);
			set => SetProperty(ref _isVisible, value);
		}
	}
}
