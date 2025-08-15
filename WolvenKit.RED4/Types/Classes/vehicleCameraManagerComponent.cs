using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleCameraManagerComponent : gameComponent
	{
		[Ordinal(4)] 
		[RED("cinematicCameraEntityTemplate")] 
		public CResourceAsyncReference<entEntityTemplate> CinematicCameraEntityTemplate
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		public vehicleCameraManagerComponent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
