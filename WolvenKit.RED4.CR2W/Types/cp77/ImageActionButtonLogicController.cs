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

		[Ordinal(28)] 
		[RED("tallImageWidget")] 
		public inkImageWidgetReference TallImageWidget
		{
			get
			{
				if (_tallImageWidget == null)
				{
					_tallImageWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "tallImageWidget", cr2w, this);
				}
				return _tallImageWidget;
			}
			set
			{
				if (_tallImageWidget == value)
				{
					return;
				}
				_tallImageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("price")] 
		public CInt32 Price
		{
			get
			{
				if (_price == null)
				{
					_price = (CInt32) CR2WTypeManager.Create("Int32", "price", cr2w, this);
				}
				return _price;
			}
			set
			{
				if (_price == value)
				{
					return;
				}
				_price = value;
				PropertySet(this);
			}
		}

		public ImageActionButtonLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
