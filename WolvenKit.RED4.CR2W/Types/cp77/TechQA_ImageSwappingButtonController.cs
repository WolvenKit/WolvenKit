using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TechQA_ImageSwappingButtonController : inkWidgetLogicController
	{
		private CName _textWidgetPath;
		private wCHandle<inkTextWidget> _textWidget;

		[Ordinal(1)] 
		[RED("textWidgetPath")] 
		public CName TextWidgetPath
		{
			get
			{
				if (_textWidgetPath == null)
				{
					_textWidgetPath = (CName) CR2WTypeManager.Create("CName", "textWidgetPath", cr2w, this);
				}
				return _textWidgetPath;
			}
			set
			{
				if (_textWidgetPath == value)
				{
					return;
				}
				_textWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("textWidget")] 
		public wCHandle<inkTextWidget> TextWidget
		{
			get
			{
				if (_textWidget == null)
				{
					_textWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "textWidget", cr2w, this);
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

		public TechQA_ImageSwappingButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
