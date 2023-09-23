using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TvInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] 
		[RED("defaultUI")] 
		public CWeakHandle<inkCanvasWidget> DefaultUI
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(17)] 
		[RED("securedUI")] 
		public CWeakHandle<inkCanvasWidget> SecuredUI
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(18)] 
		[RED("channellTextWidget")] 
		public CWeakHandle<inkTextWidget> ChannellTextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(19)] 
		[RED("securedTextWidget")] 
		public CWeakHandle<inkTextWidget> SecuredTextWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(20)] 
		[RED("mainDisplayWidget")] 
		public CWeakHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetPropertyValue<CWeakHandle<inkVideoWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVideoWidget>>(value);
		}

		[Ordinal(21)] 
		[RED("actionsList")] 
		public CWeakHandle<inkWidget> ActionsList
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(22)] 
		[RED("activeChannelIDX")] 
		public CInt32 ActiveChannelIDX
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(23)] 
		[RED("activeSequence")] 
		public CArray<SequenceVideo> ActiveSequence
		{
			get => GetPropertyValue<CArray<SequenceVideo>>();
			set => SetPropertyValue<CArray<SequenceVideo>>(value);
		}

		[Ordinal(24)] 
		[RED("activeSequenceVideo")] 
		public CInt32 ActiveSequenceVideo
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(25)] 
		[RED("globalTVChannels")] 
		public CArray<CWeakHandle<inkWidget>> GlobalTVChannels
		{
			get => GetPropertyValue<CArray<CWeakHandle<inkWidget>>>();
			set => SetPropertyValue<CArray<CWeakHandle<inkWidget>>>(value);
		}

		[Ordinal(26)] 
		[RED("messegeWidget")] 
		public CWeakHandle<inkTextWidget> MessegeWidget
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("backgroundWidget")] 
		public CWeakHandle<inkLeafWidget> BackgroundWidget
		{
			get => GetPropertyValue<CWeakHandle<inkLeafWidget>>();
			set => SetPropertyValue<CWeakHandle<inkLeafWidget>>(value);
		}

		[Ordinal(28)] 
		[RED("previousGlobalTVChannelID")] 
		public CInt32 PreviousGlobalTVChannelID
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(29)] 
		[RED("globalTVchanellsCount")] 
		public CInt32 GlobalTVchanellsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(30)] 
		[RED("globalTVchanellsSpawned")] 
		public CInt32 GlobalTVchanellsSpawned
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(31)] 
		[RED("globalTVslot")] 
		public CWeakHandle<inkWidget> GlobalTVslot
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(32)] 
		[RED("activeAudio")] 
		public CName ActiveAudio
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(33)] 
		[RED("activeMessage")] 
		public CWeakHandle<gamedataScreenMessageData_Record> ActiveMessage
		{
			get => GetPropertyValue<CWeakHandle<gamedataScreenMessageData_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataScreenMessageData_Record>>(value);
		}

		[Ordinal(34)] 
		[RED("onChangeChannelListener")] 
		public CHandle<redCallbackObject> OnChangeChannelListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(35)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public TvInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
