using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIStatusWidgetLogicController : inkWidgetLogicController
	{
		private CColor _enableStateColor;
		private CColor _disableStateColor;
		private wCHandle<inkTextWidget> _textWidget;
		private wCHandle<inkRectangleWidget> _iconWidget;

		[Ordinal(1)] 
		[RED("enableStateColor")] 
		public CColor EnableStateColor
		{
			get
			{
				if (_enableStateColor == null)
				{
					_enableStateColor = (CColor) CR2WTypeManager.Create("Color", "enableStateColor", cr2w, this);
				}
				return _enableStateColor;
			}
			set
			{
				if (_enableStateColor == value)
				{
					return;
				}
				_enableStateColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("disableStateColor")] 
		public CColor DisableStateColor
		{
			get
			{
				if (_disableStateColor == null)
				{
					_disableStateColor = (CColor) CR2WTypeManager.Create("Color", "disableStateColor", cr2w, this);
				}
				return _disableStateColor;
			}
			set
			{
				if (_disableStateColor == value)
				{
					return;
				}
				_disableStateColor = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("iconWidget")] 
		public wCHandle<inkRectangleWidget> IconWidget
		{
			get
			{
				if (_iconWidget == null)
				{
					_iconWidget = (wCHandle<inkRectangleWidget>) CR2WTypeManager.Create("whandle:inkRectangleWidget", "iconWidget", cr2w, this);
				}
				return _iconWidget;
			}
			set
			{
				if (_iconWidget == value)
				{
					return;
				}
				_iconWidget = value;
				PropertySet(this);
			}
		}

		public sampleUIStatusWidgetLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
