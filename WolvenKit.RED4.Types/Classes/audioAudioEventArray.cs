using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class audioAudioEventArray : ISerializable
	{
		[Ordinal(0)] 
		[RED("isSortedByRedHash")] 
		public CBool IsSortedByRedHash
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("events")] 
		public CArray<audioAudioEventMetadataArrayElement> Events
		{
			get => GetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>();
			set => SetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>(value);
		}

		[Ordinal(2)] 
		[RED("switchGroup")] 
		public CArray<audioAudioEventMetadataArrayElement> SwitchGroup
		{
			get => GetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>();
			set => SetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>(value);
		}

		[Ordinal(3)] 
		[RED("switch")] 
		public CArray<audioAudioEventMetadataArrayElement> Switch
		{
			get => GetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>();
			set => SetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>(value);
		}

		[Ordinal(4)] 
		[RED("stateGroup")] 
		public CArray<audioAudioEventMetadataArrayElement> StateGroup
		{
			get => GetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>();
			set => SetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>(value);
		}

		[Ordinal(5)] 
		[RED("state")] 
		public CArray<audioAudioEventMetadataArrayElement> State
		{
			get => GetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>();
			set => SetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>(value);
		}

		[Ordinal(6)] 
		[RED("gameParameter")] 
		public CArray<audioAudioEventMetadataArrayElement> GameParameter
		{
			get => GetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>();
			set => SetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>(value);
		}

		[Ordinal(7)] 
		[RED("bus")] 
		public CArray<audioAudioEventMetadataArrayElement> Bus
		{
			get => GetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>();
			set => SetPropertyValue<CArray<audioAudioEventMetadataArrayElement>>(value);
		}

		public audioAudioEventArray()
		{
			Events = new();
			SwitchGroup = new();
			Switch = new();
			StateGroup = new();
			State = new();
			GameParameter = new();
			Bus = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
