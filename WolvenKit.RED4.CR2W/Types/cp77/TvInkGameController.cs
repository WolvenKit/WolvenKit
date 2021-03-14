using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TvInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<inkCanvasWidget> _defaultUI;
		private wCHandle<inkCanvasWidget> _securedUI;
		private wCHandle<inkTextWidget> _channellTextWidget;
		private wCHandle<inkTextWidget> _securedTextWidget;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private wCHandle<inkWidget> _actionsList;
		private CInt32 _activeChannelIDX;
		private CArray<SequenceVideo> _activeSequence;
		private CInt32 _activeSequenceVideo;
		private CArray<wCHandle<inkWidget>> _globalTVChannels;
		private wCHandle<inkTextWidget> _messegeWidget;
		private wCHandle<inkLeafWidget> _backgroundWidget;
		private CInt32 _previousGlobalTVChannelID;
		private CInt32 _globalTVchanellsCount;
		private CInt32 _globalTVchanellsSpawned;
		private wCHandle<inkWidget> _globalTVslot;
		private CName _activeAudio;
		private wCHandle<gamedataScreenMessageData_Record> _activeMessage;
		private CUInt32 _onChangeChannelListener;
		private CUInt32 _onGlitchingStateChangedListener;

		[Ordinal(16)] 
		[RED("defaultUI")] 
		public wCHandle<inkCanvasWidget> DefaultUI
		{
			get
			{
				if (_defaultUI == null)
				{
					_defaultUI = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "defaultUI", cr2w, this);
				}
				return _defaultUI;
			}
			set
			{
				if (_defaultUI == value)
				{
					return;
				}
				_defaultUI = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("securedUI")] 
		public wCHandle<inkCanvasWidget> SecuredUI
		{
			get
			{
				if (_securedUI == null)
				{
					_securedUI = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "securedUI", cr2w, this);
				}
				return _securedUI;
			}
			set
			{
				if (_securedUI == value)
				{
					return;
				}
				_securedUI = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("channellTextWidget")] 
		public wCHandle<inkTextWidget> ChannellTextWidget
		{
			get
			{
				if (_channellTextWidget == null)
				{
					_channellTextWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "channellTextWidget", cr2w, this);
				}
				return _channellTextWidget;
			}
			set
			{
				if (_channellTextWidget == value)
				{
					return;
				}
				_channellTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("securedTextWidget")] 
		public wCHandle<inkTextWidget> SecuredTextWidget
		{
			get
			{
				if (_securedTextWidget == null)
				{
					_securedTextWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "securedTextWidget", cr2w, this);
				}
				return _securedTextWidget;
			}
			set
			{
				if (_securedTextWidget == value)
				{
					return;
				}
				_securedTextWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("mainDisplayWidget")] 
		public wCHandle<inkVideoWidget> MainDisplayWidget
		{
			get
			{
				if (_mainDisplayWidget == null)
				{
					_mainDisplayWidget = (wCHandle<inkVideoWidget>) CR2WTypeManager.Create("whandle:inkVideoWidget", "mainDisplayWidget", cr2w, this);
				}
				return _mainDisplayWidget;
			}
			set
			{
				if (_mainDisplayWidget == value)
				{
					return;
				}
				_mainDisplayWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("actionsList")] 
		public wCHandle<inkWidget> ActionsList
		{
			get
			{
				if (_actionsList == null)
				{
					_actionsList = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "actionsList", cr2w, this);
				}
				return _actionsList;
			}
			set
			{
				if (_actionsList == value)
				{
					return;
				}
				_actionsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("activeChannelIDX")] 
		public CInt32 ActiveChannelIDX
		{
			get
			{
				if (_activeChannelIDX == null)
				{
					_activeChannelIDX = (CInt32) CR2WTypeManager.Create("Int32", "activeChannelIDX", cr2w, this);
				}
				return _activeChannelIDX;
			}
			set
			{
				if (_activeChannelIDX == value)
				{
					return;
				}
				_activeChannelIDX = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("activeSequence")] 
		public CArray<SequenceVideo> ActiveSequence
		{
			get
			{
				if (_activeSequence == null)
				{
					_activeSequence = (CArray<SequenceVideo>) CR2WTypeManager.Create("array:SequenceVideo", "activeSequence", cr2w, this);
				}
				return _activeSequence;
			}
			set
			{
				if (_activeSequence == value)
				{
					return;
				}
				_activeSequence = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("activeSequenceVideo")] 
		public CInt32 ActiveSequenceVideo
		{
			get
			{
				if (_activeSequenceVideo == null)
				{
					_activeSequenceVideo = (CInt32) CR2WTypeManager.Create("Int32", "activeSequenceVideo", cr2w, this);
				}
				return _activeSequenceVideo;
			}
			set
			{
				if (_activeSequenceVideo == value)
				{
					return;
				}
				_activeSequenceVideo = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("globalTVChannels")] 
		public CArray<wCHandle<inkWidget>> GlobalTVChannels
		{
			get
			{
				if (_globalTVChannels == null)
				{
					_globalTVChannels = (CArray<wCHandle<inkWidget>>) CR2WTypeManager.Create("array:whandle:inkWidget", "globalTVChannels", cr2w, this);
				}
				return _globalTVChannels;
			}
			set
			{
				if (_globalTVChannels == value)
				{
					return;
				}
				_globalTVChannels = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("messegeWidget")] 
		public wCHandle<inkTextWidget> MessegeWidget
		{
			get
			{
				if (_messegeWidget == null)
				{
					_messegeWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "messegeWidget", cr2w, this);
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

		[Ordinal(27)] 
		[RED("backgroundWidget")] 
		public wCHandle<inkLeafWidget> BackgroundWidget
		{
			get
			{
				if (_backgroundWidget == null)
				{
					_backgroundWidget = (wCHandle<inkLeafWidget>) CR2WTypeManager.Create("whandle:inkLeafWidget", "backgroundWidget", cr2w, this);
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

		[Ordinal(28)] 
		[RED("previousGlobalTVChannelID")] 
		public CInt32 PreviousGlobalTVChannelID
		{
			get
			{
				if (_previousGlobalTVChannelID == null)
				{
					_previousGlobalTVChannelID = (CInt32) CR2WTypeManager.Create("Int32", "previousGlobalTVChannelID", cr2w, this);
				}
				return _previousGlobalTVChannelID;
			}
			set
			{
				if (_previousGlobalTVChannelID == value)
				{
					return;
				}
				_previousGlobalTVChannelID = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("globalTVchanellsCount")] 
		public CInt32 GlobalTVchanellsCount
		{
			get
			{
				if (_globalTVchanellsCount == null)
				{
					_globalTVchanellsCount = (CInt32) CR2WTypeManager.Create("Int32", "globalTVchanellsCount", cr2w, this);
				}
				return _globalTVchanellsCount;
			}
			set
			{
				if (_globalTVchanellsCount == value)
				{
					return;
				}
				_globalTVchanellsCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("globalTVchanellsSpawned")] 
		public CInt32 GlobalTVchanellsSpawned
		{
			get
			{
				if (_globalTVchanellsSpawned == null)
				{
					_globalTVchanellsSpawned = (CInt32) CR2WTypeManager.Create("Int32", "globalTVchanellsSpawned", cr2w, this);
				}
				return _globalTVchanellsSpawned;
			}
			set
			{
				if (_globalTVchanellsSpawned == value)
				{
					return;
				}
				_globalTVchanellsSpawned = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("globalTVslot")] 
		public wCHandle<inkWidget> GlobalTVslot
		{
			get
			{
				if (_globalTVslot == null)
				{
					_globalTVslot = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "globalTVslot", cr2w, this);
				}
				return _globalTVslot;
			}
			set
			{
				if (_globalTVslot == value)
				{
					return;
				}
				_globalTVslot = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("activeAudio")] 
		public CName ActiveAudio
		{
			get
			{
				if (_activeAudio == null)
				{
					_activeAudio = (CName) CR2WTypeManager.Create("CName", "activeAudio", cr2w, this);
				}
				return _activeAudio;
			}
			set
			{
				if (_activeAudio == value)
				{
					return;
				}
				_activeAudio = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("activeMessage")] 
		public wCHandle<gamedataScreenMessageData_Record> ActiveMessage
		{
			get
			{
				if (_activeMessage == null)
				{
					_activeMessage = (wCHandle<gamedataScreenMessageData_Record>) CR2WTypeManager.Create("whandle:gamedataScreenMessageData_Record", "activeMessage", cr2w, this);
				}
				return _activeMessage;
			}
			set
			{
				if (_activeMessage == value)
				{
					return;
				}
				_activeMessage = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("onChangeChannelListener")] 
		public CUInt32 OnChangeChannelListener
		{
			get
			{
				if (_onChangeChannelListener == null)
				{
					_onChangeChannelListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onChangeChannelListener", cr2w, this);
				}
				return _onChangeChannelListener;
			}
			set
			{
				if (_onChangeChannelListener == value)
				{
					return;
				}
				_onChangeChannelListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get
			{
				if (_onGlitchingStateChangedListener == null)
				{
					_onGlitchingStateChangedListener = (CUInt32) CR2WTypeManager.Create("Uint32", "onGlitchingStateChangedListener", cr2w, this);
				}
				return _onGlitchingStateChangedListener;
			}
			set
			{
				if (_onGlitchingStateChangedListener == value)
				{
					return;
				}
				_onGlitchingStateChangedListener = value;
				PropertySet(this);
			}
		}

		public TvInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
