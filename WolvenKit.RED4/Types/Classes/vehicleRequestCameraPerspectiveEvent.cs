using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleRequestCameraPerspectiveEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("cameraPerspective")] 
		public CEnum<vehicleCameraPerspective> CameraPerspective
		{
			get => GetPropertyValue<CEnum<vehicleCameraPerspective>>();
			set => SetPropertyValue<CEnum<vehicleCameraPerspective>>(value);
		}

		public vehicleRequestCameraPerspectiveEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
