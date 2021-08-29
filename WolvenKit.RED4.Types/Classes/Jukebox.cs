using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class Jukebox : InteractiveDevice
	{
		private CWeakHandle<IWorldWidgetComponent> _uiComponentBig;

		[Ordinal(97)] 
		[RED("uiComponentBig")] 
		public CWeakHandle<IWorldWidgetComponent> UiComponentBig
		{
			get => GetProperty(ref _uiComponentBig);
			set => SetProperty(ref _uiComponentBig, value);
		}
	}
}
