using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ImageActionButtonLogicController : DeviceActionWidgetControllerBase
	{
		private inkImageWidgetReference _tallImageWidget;
		private CInt32 _price;

		[Ordinal(29)] 
		[RED("tallImageWidget")] 
		public inkImageWidgetReference TallImageWidget
		{
			get => GetProperty(ref _tallImageWidget);
			set => SetProperty(ref _tallImageWidget, value);
		}

		[Ordinal(30)] 
		[RED("price")] 
		public CInt32 Price
		{
			get => GetProperty(ref _price);
			set => SetProperty(ref _price, value);
		}
	}
}
