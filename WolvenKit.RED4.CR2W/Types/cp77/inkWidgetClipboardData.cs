using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWidgetClipboardData : ISerializable
	{
		private CHandle<inkWidget> _widget;
		private inkWidgetPath _widgetPath;

		[Ordinal(0)] 
		[RED("widget")] 
		public CHandle<inkWidget> Widget
		{
			get
			{
				if (_widget == null)
				{
					_widget = (CHandle<inkWidget>) CR2WTypeManager.Create("handle:inkWidget", "widget", cr2w, this);
				}
				return _widget;
			}
			set
			{
				if (_widget == value)
				{
					return;
				}
				_widget = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("widgetPath")] 
		public inkWidgetPath WidgetPath
		{
			get
			{
				if (_widgetPath == null)
				{
					_widgetPath = (inkWidgetPath) CR2WTypeManager.Create("inkWidgetPath", "widgetPath", cr2w, this);
				}
				return _widgetPath;
			}
			set
			{
				if (_widgetPath == value)
				{
					return;
				}
				_widgetPath = value;
				PropertySet(this);
			}
		}

		public inkWidgetClipboardData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
