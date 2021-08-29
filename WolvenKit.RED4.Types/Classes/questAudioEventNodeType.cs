using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questAudioEventNodeType : questIAudioNodeType
	{
		private CArray<audioAudEventStruct> _events;
		private CArray<audioAudEventStruct> _musicEvents;
		private CArray<audioAudSwitch> _switches;
		private CArray<audioAudParameter> _params;
		private CArray<CName> _dynamicParams;
		private audioAudEventStruct _event;
		private CName _ambientUniqueName;
		private CName _emitter;
		private CBool _isMusic;
		private gameEntityReference _objectRef;
		private CBool _isPlayer;

		[Ordinal(0)] 
		[RED("events")] 
		public CArray<audioAudEventStruct> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}

		[Ordinal(1)] 
		[RED("musicEvents")] 
		public CArray<audioAudEventStruct> MusicEvents
		{
			get => GetProperty(ref _musicEvents);
			set => SetProperty(ref _musicEvents, value);
		}

		[Ordinal(2)] 
		[RED("switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get => GetProperty(ref _switches);
			set => SetProperty(ref _switches, value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CArray<audioAudParameter> Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(4)] 
		[RED("dynamicParams")] 
		public CArray<CName> DynamicParams
		{
			get => GetProperty(ref _dynamicParams);
			set => SetProperty(ref _dynamicParams, value);
		}

		[Ordinal(5)] 
		[RED("event")] 
		public audioAudEventStruct Event
		{
			get => GetProperty(ref _event);
			set => SetProperty(ref _event, value);
		}

		[Ordinal(6)] 
		[RED("ambientUniqueName")] 
		public CName AmbientUniqueName
		{
			get => GetProperty(ref _ambientUniqueName);
			set => SetProperty(ref _ambientUniqueName, value);
		}

		[Ordinal(7)] 
		[RED("emitter")] 
		public CName Emitter
		{
			get => GetProperty(ref _emitter);
			set => SetProperty(ref _emitter, value);
		}

		[Ordinal(8)] 
		[RED("isMusic")] 
		public CBool IsMusic
		{
			get => GetProperty(ref _isMusic);
			set => SetProperty(ref _isMusic, value);
		}

		[Ordinal(9)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(10)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}
	}
}
