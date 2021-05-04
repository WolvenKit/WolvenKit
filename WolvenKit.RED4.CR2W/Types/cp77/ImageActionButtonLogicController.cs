using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ImageActionButtonLogicController : DeviceActionWidgetControllerBase
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

		public ImageActionButtonLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
