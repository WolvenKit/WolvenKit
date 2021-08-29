using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ZoomBlockedEvents : ZoomEventsTransition
	{
		private CEnum<vehicleCameraPerspective> _previousCameraPerspective;
		private CBool _previousCameraPerspectiveValid;

		[Ordinal(0)] 
		[RED("previousCameraPerspective")] 
		public CEnum<vehicleCameraPerspective> PreviousCameraPerspective
		{
			get => GetProperty(ref _previousCameraPerspective);
			set => SetProperty(ref _previousCameraPerspective, value);
		}

		[Ordinal(1)] 
		[RED("previousCameraPerspectiveValid")] 
		public CBool PreviousCameraPerspectiveValid
		{
			get => GetProperty(ref _previousCameraPerspectiveValid);
			set => SetProperty(ref _previousCameraPerspectiveValid, value);
		}
	}
}
