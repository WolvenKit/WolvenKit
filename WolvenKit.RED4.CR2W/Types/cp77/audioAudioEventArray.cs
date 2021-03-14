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
			get
			{
				if (_isSortedByRedHash == null)
				{
					_isSortedByRedHash = (CBool) CR2WTypeManager.Create("Bool", "isSortedByRedHash", cr2w, this);
				}
				return _isSortedByRedHash;
			}
			set
			{
				if (_isSortedByRedHash == value)
				{
					return;
				}
				_isSortedByRedHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("events")] 
		public CArray<audioAudioEventMetadataArrayElement> Events
		{
			get
			{
				if (_events == null)
				{
					_events = (CArray<audioAudioEventMetadataArrayElement>) CR2WTypeManager.Create("array:audioAudioEventMetadataArrayElement", "events", cr2w, this);
				}
				return _events;
			}
			set
			{
				if (_events == value)
				{
					return;
				}
				_events = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("switchGroup")] 
		public CArray<audioAudioEventMetadataArrayElement> SwitchGroup
		{
			get
			{
				if (_switchGroup == null)
				{
					_switchGroup = (CArray<audioAudioEventMetadataArrayElement>) CR2WTypeManager.Create("array:audioAudioEventMetadataArrayElement", "switchGroup", cr2w, this);
				}
				return _switchGroup;
			}
			set
			{
				if (_switchGroup == value)
				{
					return;
				}
				_switchGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("switch")] 
		public CArray<audioAudioEventMetadataArrayElement> Switch
		{
			get
			{
				if (_switch == null)
				{
					_switch = (CArray<audioAudioEventMetadataArrayElement>) CR2WTypeManager.Create("array:audioAudioEventMetadataArrayElement", "switch", cr2w, this);
				}
				return _switch;
			}
			set
			{
				if (_switch == value)
				{
					return;
				}
				_switch = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("stateGroup")] 
		public CArray<audioAudioEventMetadataArrayElement> StateGroup
		{
			get
			{
				if (_stateGroup == null)
				{
					_stateGroup = (CArray<audioAudioEventMetadataArrayElement>) CR2WTypeManager.Create("array:audioAudioEventMetadataArrayElement", "stateGroup", cr2w, this);
				}
				return _stateGroup;
			}
			set
			{
				if (_stateGroup == value)
				{
					return;
				}
				_stateGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("state")] 
		public CArray<audioAudioEventMetadataArrayElement> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CArray<audioAudioEventMetadataArrayElement>) CR2WTypeManager.Create("array:audioAudioEventMetadataArrayElement", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("gameParameter")] 
		public CArray<audioAudioEventMetadataArrayElement> GameParameter
		{
			get
			{
				if (_gameParameter == null)
				{
					_gameParameter = (CArray<audioAudioEventMetadataArrayElement>) CR2WTypeManager.Create("array:audioAudioEventMetadataArrayElement", "gameParameter", cr2w, this);
				}
				return _gameParameter;
			}
			set
			{
				if (_gameParameter == value)
				{
					return;
				}
				_gameParameter = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("bus")] 
		public CArray<audioAudioEventMetadataArrayElement> Bus
		{
			get
			{
				if (_bus == null)
				{
					_bus = (CArray<audioAudioEventMetadataArrayElement>) CR2WTypeManager.Create("array:audioAudioEventMetadataArrayElement", "bus", cr2w, this);
				}
				return _bus;
			}
			set
			{
				if (_bus == value)
				{
					return;
				}
				_bus = value;
				PropertySet(this);
			}
		}

		public audioAudioEventArray(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
