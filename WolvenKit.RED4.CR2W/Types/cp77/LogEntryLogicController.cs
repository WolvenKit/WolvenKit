using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LogEntryLogicController : inkWidgetLogicController
	{
		private wCHandle<inkWidget> _root;
		private inkTextWidgetReference _textWidget;
		private CHandle<inkanimProxy> _animProxyTimeout;
		private CHandle<inkanimProxy> _animProxyFadeOut;

		[Ordinal(1)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
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

		[Ordinal(2)] 
		[RED("textWidget")] 
		public inkTextWidgetReference TextWidget
		{
			get
			{
				if (_textWidget == null)
				{
					_textWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "textWidget", cr2w, this);
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

		[Ordinal(3)] 
		[RED("animProxyTimeout")] 
		public CHandle<inkanimProxy> AnimProxyTimeout
		{
			get
			{
				if (_animProxyTimeout == null)
				{
					_animProxyTimeout = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxyTimeout", cr2w, this);
				}
				return _animProxyTimeout;
			}
			set
			{
				if (_animProxyTimeout == value)
				{
					return;
				}
				_animProxyTimeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("animProxyFadeOut")] 
		public CHandle<inkanimProxy> AnimProxyFadeOut
		{
			get
			{
				if (_animProxyFadeOut == null)
				{
					_animProxyFadeOut = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxyFadeOut", cr2w, this);
				}
				return _animProxyFadeOut;
			}
			set
			{
				if (_animProxyFadeOut == value)
				{
					return;
				}
				_animProxyFadeOut = value;
				PropertySet(this);
			}
		}

		public LogEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
