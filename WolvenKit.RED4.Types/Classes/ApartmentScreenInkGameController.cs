using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ApartmentScreenInkGameController : LcdScreenInkGameController
	{
		private CWeakHandle<inkImageWidget> _backgroundFrameWidget;

		[Ordinal(25)] 
		[RED("backgroundFrameWidget")] 
		public CWeakHandle<inkImageWidget> BackgroundFrameWidget
		{
			get => GetProperty(ref _backgroundFrameWidget);
			set => SetProperty(ref _backgroundFrameWidget, value);
		}
	}
}
