using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NarrativePlateLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _textWidget;
		private inkWidgetReference _captionWidget;
		private inkWidgetReference _root;

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

		[Ordinal(2)] 
		[RED("captionWidget")] 
		public inkWidgetReference CaptionWidget
		{
			get
			{
				if (_captionWidget == null)
				{
					_captionWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "captionWidget", cr2w, this);
				}
				return _captionWidget;
			}
			set
			{
				if (_captionWidget == value)
				{
					return;
				}
				_captionWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get
			{
				if (_root == null)
				{
					_root = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		public NarrativePlateLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
