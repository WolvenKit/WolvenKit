using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TvDeviceWidgetController : DeviceWidgetControllerBase
	{
		private inkVideoWidgetReference _videoWidget;
		private inkBasePanelWidgetReference _globalTVChannelSlot;
		private inkTextWidgetReference _messegeWidget;
		private inkLeafWidgetReference _messageBackgroundWidget;
		private wCHandle<inkWidget> _globalTVChannel;
		private redResourceReferenceScriptToken _activeVideo;

		[Ordinal(10)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get
			{
				if (_videoWidget == null)
				{
					_videoWidget = (inkVideoWidgetReference) CR2WTypeManager.Create("inkVideoWidgetReference", "videoWidget", cr2w, this);
				}
				return _videoWidget;
			}
			set
			{
				if (_videoWidget == value)
				{
					return;
				}
				_videoWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("globalTVChannelSlot")] 
		public inkBasePanelWidgetReference GlobalTVChannelSlot
		{
			get
			{
				if (_globalTVChannelSlot == null)
				{
					_globalTVChannelSlot = (inkBasePanelWidgetReference) CR2WTypeManager.Create("inkBasePanelWidgetReference", "globalTVChannelSlot", cr2w, this);
				}
				return _globalTVChannelSlot;
			}
			set
			{
				if (_globalTVChannelSlot == value)
				{
					return;
				}
				_globalTVChannelSlot = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("messegeWidget")] 
		public inkTextWidgetReference MessegeWidget
		{
			get
			{
				if (_messegeWidget == null)
				{
					_messegeWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "messegeWidget", cr2w, this);
				}
				return _messegeWidget;
			}
			set
			{
				if (_messegeWidget == value)
				{
					return;
				}
				_messegeWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("messageBackgroundWidget")] 
		public inkLeafWidgetReference MessageBackgroundWidget
		{
			get
			{
				if (_messageBackgroundWidget == null)
				{
					_messageBackgroundWidget = (inkLeafWidgetReference) CR2WTypeManager.Create("inkLeafWidgetReference", "messageBackgroundWidget", cr2w, this);
				}
				return _messageBackgroundWidget;
			}
			set
			{
				if (_messageBackgroundWidget == value)
				{
					return;
				}
				_messageBackgroundWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("globalTVChannel")] 
		public wCHandle<inkWidget> GlobalTVChannel
		{
			get
			{
				if (_globalTVChannel == null)
				{
					_globalTVChannel = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "globalTVChannel", cr2w, this);
				}
				return _globalTVChannel;
			}
			set
			{
				if (_globalTVChannel == value)
				{
					return;
				}
				_globalTVChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("activeVideo")] 
		public redResourceReferenceScriptToken ActiveVideo
		{
			get
			{
				if (_activeVideo == null)
				{
					_activeVideo = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "activeVideo", cr2w, this);
				}
				return _activeVideo;
			}
			set
			{
				if (_activeVideo == value)
				{
					return;
				}
				_activeVideo = value;
				PropertySet(this);
			}
		}

		public TvDeviceWidgetController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
