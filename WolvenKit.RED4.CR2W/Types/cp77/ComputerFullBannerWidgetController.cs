using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerFullBannerWidgetController : ComputerBannerWidgetController
	{
		private inkWidgetReference _closeButtonWidget;

		[Ordinal(12)] 
		[RED("closeButtonWidget")] 
		public inkWidgetReference CloseButtonWidget
		{
			get
			{
				if (_closeButtonWidget == null)
				{
					_closeButtonWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "closeButtonWidget", cr2w, this);
				}
				return _closeButtonWidget;
			}
			set
			{
				if (_closeButtonWidget == value)
				{
					return;
				}
				_closeButtonWidget = value;
				PropertySet(this);
			}
		}

		public ComputerFullBannerWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
