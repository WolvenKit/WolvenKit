using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questAudioEventNodeType : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("events")] 
		public CArray<audioAudEventStruct> Events
		{
			get => GetPropertyValue<CArray<audioAudEventStruct>>();
			set => SetPropertyValue<CArray<audioAudEventStruct>>(value);
		}

		[Ordinal(1)] 
		[RED("musicEvents")] 
		public CArray<audioAudEventStruct> MusicEvents
		{
			get => GetPropertyValue<CArray<audioAudEventStruct>>();
			set => SetPropertyValue<CArray<audioAudEventStruct>>(value);
		}

		[Ordinal(2)] 
		[RED("switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get => GetPropertyValue<CArray<audioAudSwitch>>();
			set => SetPropertyValue<CArray<audioAudSwitch>>(value);
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CArray<audioAudParameter> Params
		{
			get => GetPropertyValue<CArray<audioAudParameter>>();
			set => SetPropertyValue<CArray<audioAudParameter>>(value);
		}

		[Ordinal(4)] 
		[RED("dynamicParams")] 
		public CArray<CName> DynamicParams
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(5)] 
		[RED("event")] 
		public audioAudEventStruct Event
		{
			get => GetPropertyValue<audioAudEventStruct>();
			set => SetPropertyValue<audioAudEventStruct>(value);
		}

		[Ordinal(6)] 
		[RED("ambientUniqueName")] 
		public CName AmbientUniqueName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("emitter")] 
		public CName Emitter
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("isMusic")] 
		public CBool IsMusic
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(10)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questAudioEventNodeType()
		{
			Events = new();
			MusicEvents = new();
			Switches = new();
			Params = new();
			DynamicParams = new();
			Event = new audioAudEventStruct();
			ObjectRef = new gameEntityReference { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
