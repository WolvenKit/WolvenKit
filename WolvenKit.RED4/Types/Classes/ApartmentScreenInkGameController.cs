using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ApartmentScreenInkGameController : LcdScreenInkGameController
	{
		[Ordinal(25)] 
		[RED("backgroundFrameWidget")] 
		public CWeakHandle<inkImageWidget> BackgroundFrameWidget
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		public ApartmentScreenInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
