using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		}
	}
}
