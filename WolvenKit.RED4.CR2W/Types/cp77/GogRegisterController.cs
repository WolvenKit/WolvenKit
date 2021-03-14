using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GogRegisterController : gameuiBaseGOGRegisterController
	{
		private inkWidgetReference _linkWidget;
		private inkWidgetReference _qrImageWidget;

		[Ordinal(1)] 
		[RED("linkWidget")] 
		public inkWidgetReference LinkWidget
		{
			get
			{
				if (_linkWidget == null)
				{
					_linkWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "linkWidget", cr2w, this);
				}
				return _linkWidget;
			}
			set
			{
				if (_linkWidget == value)
				{
					return;
				}
				_linkWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("qrImageWidget")] 
		public inkWidgetReference QrImageWidget
		{
			get
			{
				if (_qrImageWidget == null)
				{
					_qrImageWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "qrImageWidget", cr2w, this);
				}
				return _qrImageWidget;
			}
			set
			{
				if (_qrImageWidget == value)
				{
					return;
				}
				_qrImageWidget = value;
				PropertySet(this);
			}
		}

		public GogRegisterController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
