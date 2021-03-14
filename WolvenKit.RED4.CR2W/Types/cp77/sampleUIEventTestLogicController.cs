using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIEventTestLogicController : inkWidgetLogicController
	{
		private CName _eventTextWidgetPath;
		private CName _eventVerticalPanelPath;
		private CName _callbackTextWidgetPath;
		private CName _callbackVerticalPanelPath;
		private CName _customCallbackName;
		private wCHandle<inkTextWidget> _textWidget;
		private wCHandle<inkVerticalPanelWidget> _verticalPanelWidget;
		private CBool _isEnabled;

		[Ordinal(1)] 
		[RED("eventTextWidgetPath")] 
		public CName EventTextWidgetPath
		{
			get
			{
				if (_eventTextWidgetPath == null)
				{
					_eventTextWidgetPath = (CName) CR2WTypeManager.Create("CName", "eventTextWidgetPath", cr2w, this);
				}
				return _eventTextWidgetPath;
			}
			set
			{
				if (_eventTextWidgetPath == value)
				{
					return;
				}
				_eventTextWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("eventVerticalPanelPath")] 
		public CName EventVerticalPanelPath
		{
			get
			{
				if (_eventVerticalPanelPath == null)
				{
					_eventVerticalPanelPath = (CName) CR2WTypeManager.Create("CName", "eventVerticalPanelPath", cr2w, this);
				}
				return _eventVerticalPanelPath;
			}
			set
			{
				if (_eventVerticalPanelPath == value)
				{
					return;
				}
				_eventVerticalPanelPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("callbackTextWidgetPath")] 
		public CName CallbackTextWidgetPath
		{
			get
			{
				if (_callbackTextWidgetPath == null)
				{
					_callbackTextWidgetPath = (CName) CR2WTypeManager.Create("CName", "callbackTextWidgetPath", cr2w, this);
				}
				return _callbackTextWidgetPath;
			}
			set
			{
				if (_callbackTextWidgetPath == value)
				{
					return;
				}
				_callbackTextWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("callbackVerticalPanelPath")] 
		public CName CallbackVerticalPanelPath
		{
			get
			{
				if (_callbackVerticalPanelPath == null)
				{
					_callbackVerticalPanelPath = (CName) CR2WTypeManager.Create("CName", "callbackVerticalPanelPath", cr2w, this);
				}
				return _callbackVerticalPanelPath;
			}
			set
			{
				if (_callbackVerticalPanelPath == value)
				{
					return;
				}
				_callbackVerticalPanelPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("customCallbackName")] 
		public CName CustomCallbackName
		{
			get
			{
				if (_customCallbackName == null)
				{
					_customCallbackName = (CName) CR2WTypeManager.Create("CName", "customCallbackName", cr2w, this);
				}
				return _customCallbackName;
			}
			set
			{
				if (_customCallbackName == value)
				{
					return;
				}
				_customCallbackName = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
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

		[Ordinal(7)] 
		[RED("verticalPanelWidget")] 
		public wCHandle<inkVerticalPanelWidget> VerticalPanelWidget
		{
			get
			{
				if (_verticalPanelWidget == null)
				{
					_verticalPanelWidget = (wCHandle<inkVerticalPanelWidget>) CR2WTypeManager.Create("whandle:inkVerticalPanelWidget", "verticalPanelWidget", cr2w, this);
				}
				return _verticalPanelWidget;
			}
			set
			{
				if (_verticalPanelWidget == value)
				{
					return;
				}
				_verticalPanelWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get
			{
				if (_isEnabled == null)
				{
					_isEnabled = (CBool) CR2WTypeManager.Create("Bool", "isEnabled", cr2w, this);
				}
				return _isEnabled;
			}
			set
			{
				if (_isEnabled == value)
				{
					return;
				}
				_isEnabled = value;
				PropertySet(this);
			}
		}

		public sampleUIEventTestLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
