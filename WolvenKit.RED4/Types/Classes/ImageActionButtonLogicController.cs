using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ImageActionButtonLogicController : DeviceActionWidgetControllerBase
	{
		[Ordinal(32)] 
		[RED("tallImageWidget")] 
		public inkImageWidgetReference TallImageWidget
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("price")] 
		public CInt32 Price
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public ImageActionButtonLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
