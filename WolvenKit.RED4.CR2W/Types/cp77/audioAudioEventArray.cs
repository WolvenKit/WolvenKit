using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAudioEventArray : ISerializable
	{
		private CBool _isSortedByRedHash;
		private CArray<audioAudioEventMetadataArrayElement> _events;
		private CArray<audioAudioEventMetadataArrayElement> _switchGroup;
		private CArray<audioAudioEventMetadataArrayElement> _switch;
		private CArray<audioAudioEventMetadataArrayElement> _stateGroup;
		private CArray<audioAudioEventMetadataArrayElement> _state;
		private CArray<audioAudioEventMetadataArrayElement> _gameParameter;
		private CArray<audioAudioEventMetadataArrayElement> _bus;

		[Ordinal(0)] 
		[RED("isSortedByRedHash")] 
		public CBool IsSortedByRedHash
		{
			get => GetProperty(ref _isSortedByRedHash);
			set => SetProperty(ref _isSortedByRedHash, value);
		}

		[Ordinal(1)] 
		[RED("events")] 
		public CArray<audioAudioEventMetadataArrayElement> Events
		{
			get => GetProperty(ref _events);
			set => SetProperty(ref _events, value);
		}

		[Ordinal(2)] 
		[RED("switchGroup")] 
		public CArray<audioAudioEventMetadataArrayElement> SwitchGroup
		{
			get => GetProperty(ref _switchGroup);
			set => SetProperty(ref _switchGroup, value);
		}

		[Ordinal(3)] 
		[RED("switch")] 
		public CArray<audioAudioEventMetadataArrayElement> Switch
		{
			get => GetProperty(ref _switch);
			set => SetProperty(ref _switch, value);
		}

		[Ordinal(4)] 
		[RED("stateGroup")] 
		public CArray<audioAudioEventMetadataArrayElement> StateGroup
		{
			get => GetProperty(ref _stateGroup);
			set => SetProperty(ref _stateGroup, value);
		}

		[Ordinal(5)] 
		[RED("state")] 
		public CArray<audioAudioEventMetadataArrayElement> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(6)] 
		[RED("gameParameter")] 
		public CArray<audioAudioEventMetadataArrayElement> GameParameter
		{
			get => GetProperty(ref _gameParameter);
			set => SetProperty(ref _gameParameter, value);
		}

		[Ordinal(7)] 
		[RED("bus")] 
		public CArray<audioAudioEventMetadataArrayElement> Bus
		{
			get => GetProperty(ref _bus);
			set => SetProperty(ref _bus, value);
		}

		public audioAudioEventArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
