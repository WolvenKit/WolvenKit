using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Jukebox : InteractiveDevice
	{
		[Ordinal(94)] 
		[RED("uiComponentBig")] 
		public CWeakHandle<IWorldWidgetComponent> UiComponentBig
		{
			get => GetPropertyValue<CWeakHandle<IWorldWidgetComponent>>();
			set => SetPropertyValue<CWeakHandle<IWorldWidgetComponent>>(value);
		}

		public Jukebox()
		{
			ControllerTypeName = "JukeboxController";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
