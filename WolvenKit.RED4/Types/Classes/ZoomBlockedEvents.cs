using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ZoomBlockedEvents : ZoomEventsTransition
	{
		[Ordinal(0)] 
		[RED("previousCameraPerspective")] 
		public CEnum<vehicleCameraPerspective> PreviousCameraPerspective
		{
			get => GetPropertyValue<CEnum<vehicleCameraPerspective>>();
			set => SetPropertyValue<CEnum<vehicleCameraPerspective>>(value);
		}

		[Ordinal(1)] 
		[RED("previousCameraPerspectiveValid")] 
		public CBool PreviousCameraPerspectiveValid
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ZoomBlockedEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
