using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeCameraLocation : inkWidgetLogicController
	{
		private inkWidgetReference _textWidget;

		[Ordinal(1)] 
		[RED("textWidget")] 
		public inkWidgetReference TextWidget
		{
			get
			{
				if (_textWidget == null)
				{
					_textWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "textWidget", cr2w, this);
				}
				return _textWidget;
			}
			set
			{
				if (_textWidget == value)
				{
					return;
				}
				_textWidget = value;
				PropertySet(this);
			}
		}

		public PhotoModeCameraLocation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
