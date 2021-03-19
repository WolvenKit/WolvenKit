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
			get => GetProperty(ref _defaultUI);
			set => SetProperty(ref _defaultUI, value);
		}

		[Ordinal(17)] 
		[RED("securedUI")] 
		public wCHandle<inkCanvasWidget> SecuredUI
		{
			get => GetProperty(ref _securedUI);
			set => SetProperty(ref _securedUI, value);
		}

		[Ordinal(18)] 
		[RED("channellTextWidget")] 
		public wCHandle<inkTextWidget> ChannellTextWidget
		{
			get => GetProperty(ref _channellTextWidget);
			set => SetProperty(ref _channellTextWidget, value);
		}

		[Ordinal(19)] 
		[RED("securedTextWidget")] 
		public wCHandle<inkTextWidget> SecuredTextWidget
		{
			get => GetProperty(ref _securedTextWidget);
			set => SetProperty(ref _securedTextWidget, value);
		}

		[Ordinal(20)] 
		[RED("mainDisplayWidget")] 
		public wCHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetProperty(ref _mainDisplayWidget);
			set => SetProperty(ref _mainDisplayWidget, value);
		}

		[Ordinal(21)] 
		[RED("actionsList")] 
		public wCHandle<inkWidget> ActionsList
		{
			get => GetProperty(ref _actionsList);
			set => SetProperty(ref _actionsList, value);
		}

		[Ordinal(22)] 
		[RED("activeChannelIDX")] 
		public CInt32 ActiveChannelIDX
		{
			get => GetProperty(ref _activeChannelIDX);
			set => SetProperty(ref _activeChannelIDX, value);
		}

		[Ordinal(23)] 
		[RED("activeSequence")] 
		public CArray<SequenceVideo> ActiveSequence
		{
			get => GetProperty(ref _activeSequence);
			set => SetProperty(ref _activeSequence, value);
		}

		[Ordinal(24)] 
		[RED("activeSequenceVideo")] 
		public CInt32 ActiveSequenceVideo
		{
			get => GetProperty(ref _activeSequenceVideo);
			set => SetProperty(ref _activeSequenceVideo, value);
		}

		[Ordinal(25)] 
		[RED("globalTVChannels")] 
		public CArray<wCHandle<inkWidget>> GlobalTVChannels
		{
			get => GetProperty(ref _globalTVChannels);
			set => SetProperty(ref _globalTVChannels, value);
		}

		[Ordinal(26)] 
		[RED("messegeWidget")] 
		public wCHandle<inkTextWidget> MessegeWidget
		{
			get => GetProperty(ref _messegeWidget);
			set => SetProperty(ref _messegeWidget, value);
		}

		[Ordinal(27)] 
		[RED("backgroundWidget")] 
		public wCHandle<inkLeafWidget> BackgroundWidget
		{
			get => GetProperty(ref _backgroundWidget);
			set => SetProperty(ref _backgroundWidget, value);
		}

		[Ordinal(28)] 
		[RED("previousGlobalTVChannelID")] 
		public CInt32 PreviousGlobalTVChannelID
		{
			get => GetProperty(ref _previousGlobalTVChannelID);
			set => SetProperty(ref _previousGlobalTVChannelID, value);
		}

		[Ordinal(29)] 
		[RED("globalTVchanellsCount")] 
		public CInt32 GlobalTVchanellsCount
		{
			get => GetProperty(ref _globalTVchanellsCount);
			set => SetProperty(ref _globalTVchanellsCount, value);
		}

		[Ordinal(30)] 
		[RED("globalTVchanellsSpawned")] 
		public CInt32 GlobalTVchanellsSpawned
		{
			get => GetProperty(ref _globalTVchanellsSpawned);
			set => SetProperty(ref _globalTVchanellsSpawned, value);
		}

		[Ordinal(31)] 
		[RED("globalTVslot")] 
		public wCHandle<inkWidget> GlobalTVslot
		{
			get => GetProperty(ref _globalTVslot);
			set => SetProperty(ref _globalTVslot, value);
		}

		[Ordinal(32)] 
		[RED("activeAudio")] 
		public CName ActiveAudio
		{
			get => GetProperty(ref _activeAudio);
			set => SetProperty(ref _activeAudio, value);
		}

		[Ordinal(33)] 
		[RED("activeMessage")] 
		public wCHandle<gamedataScreenMessageData_Record> ActiveMessage
		{
			get => GetProperty(ref _activeMessage);
			set => SetProperty(ref _activeMessage, value);
		}

		[Ordinal(34)] 
		[RED("onChangeChannelListener")] 
		public CUInt32 OnChangeChannelListener
		{
			get => GetProperty(ref _onChangeChannelListener);
			set => SetProperty(ref _onChangeChannelListener, value);
		}

		[Ordinal(35)] 
		[RED("onGlitchingStateChangedListener")] 
		public CUInt32 OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		public TvInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
