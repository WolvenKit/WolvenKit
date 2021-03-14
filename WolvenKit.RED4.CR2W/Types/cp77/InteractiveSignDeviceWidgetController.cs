using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InteractiveSignDeviceWidgetController : DeviceWidgetControllerBase
	{
		private CName _messageWidgetPath;
		private CName _backgroundWidgetPath;
		private wCHandle<inkTextWidget> _messageWidget;
		private wCHandle<inkWidget> _backgroundWidget;

		[Ordinal(10)] 
		[RED("messageWidgetPath")] 
		public CName MessageWidgetPath
		{
			get
			{
				if (_messageWidgetPath == null)
				{
					_messageWidgetPath = (CName) CR2WTypeManager.Create("CName", "messageWidgetPath", cr2w, this);
				}
				return _messageWidgetPath;
			}
			set
			{
				if (_messageWidgetPath == value)
				{
					return;
				}
				_messageWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("backgroundWidgetPath")] 
		public CName BackgroundWidgetPath
		{
			get
			{
				if (_backgroundWidgetPath == null)
				{
					_backgroundWidgetPath = (CName) CR2WTypeManager.Create("CName", "backgroundWidgetPath", cr2w, this);
				}
				return _backgroundWidgetPath;
			}
			set
			{
				if (_backgroundWidgetPath == value)
				{
					return;
				}
				_backgroundWidgetPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("messageWidget")] 
		public wCHandle<inkTextWidget> MessageWidget
		{
			get
			{
				if (_messageWidget == null)
				{
					_messageWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "messageWidget", cr2w, this);
				}
				return _messageWidget;
			}
			set
			{
				if (_messageWidget == value)
				{
					return;
				}
				_messageWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("backgroundWidget")] 
		public wCHandle<inkWidget> BackgroundWidget
		{
			get
			{
				if (_backgroundWidget == null)
				{
					_backgroundWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "backgroundWidget", cr2w, this);
				}
				return _backgroundWidget;
			}
			set
			{
				if (_backgroundWidget == value)
				{
					return;
				}
				_backgroundWidget = value;
				PropertySet(this);
			}
		}

		public InteractiveSignDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
