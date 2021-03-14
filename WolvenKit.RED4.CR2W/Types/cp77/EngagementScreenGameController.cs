using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EngagementScreenGameController : gameuiMenuGameController
	{
		private inkVideoWidgetReference _backgroundVideo;
		private inkRichTextBoxWidgetReference _text;
		private inkRichTextBoxWidgetReference _textShadow;
		private inkCompoundWidgetReference _textContainer;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;

		[Ordinal(3)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get
			{
				if (_backgroundVideo == null)
				{
					_backgroundVideo = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "backgroundVideo", cr2w, this);
				}
				return _backgroundVideo;
			}
			set
			{
				if (_backgroundVideo == value)
				{
					return;
				}
				_backgroundVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("text")] 
		public inkRichTextBoxWidgetReference Text
		{
			get
			{
				if (_text == null)
				{
					_text = (inkRichTextBoxWidgetReference) CR2WTypeManager.Create("inkRichTextBoxWidgetReference", "text", cr2w, this);
				}
				return _text;
			}
			set
			{
				if (_text == value)
				{
					return;
				}
				_text = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("textShadow")] 
		public inkRichTextBoxWidgetReference TextShadow
		{
			get
			{
				if (_textShadow == null)
				{
					_textShadow = (inkRichTextBoxWidgetReference) CR2WTypeManager.Create("inkRichTextBoxWidgetReference", "textShadow", cr2w, this);
				}
				return _textShadow;
			}
			set
			{
				if (_textShadow == value)
				{
					return;
				}
				_textShadow = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("textContainer")] 
		public inkCompoundWidgetReference TextContainer
		{
			get
			{
				if (_textContainer == null)
				{
					_textContainer = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "textContainer", cr2w, this);
				}
				return _textContainer;
			}
			set
			{
				if (_textContainer == value)
				{
					return;
				}
				_textContainer = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get
			{
				if (_menuEventDispatcher == null)
				{
					_menuEventDispatcher = (wCHandle<inkMenuEventDispatcher>) CR2WTypeManager.Create("whandle:inkMenuEventDispatcher", "menuEventDispatcher", cr2w, this);
				}
				return _menuEventDispatcher;
			}
			set
			{
				if (_menuEventDispatcher == value)
				{
					return;
				}
				_menuEventDispatcher = value;
				PropertySet(this);
			}
		}

		public EngagementScreenGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
