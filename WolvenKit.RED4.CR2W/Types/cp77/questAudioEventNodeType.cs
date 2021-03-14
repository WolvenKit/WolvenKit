using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioEventNodeType : questIAudioNodeType
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
			get
			{
				if (_events == null)
				{
					_events = (CArray<audioAudEventStruct>) CR2WTypeManager.Create("array:audioAudEventStruct", "events", cr2w, this);
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

		[Ordinal(1)] 
		[RED("musicEvents")] 
		public CArray<audioAudEventStruct> MusicEvents
		{
			get
			{
				if (_musicEvents == null)
				{
					_musicEvents = (CArray<audioAudEventStruct>) CR2WTypeManager.Create("array:audioAudEventStruct", "musicEvents", cr2w, this);
				}
				return _musicEvents;
			}
			set
			{
				if (_musicEvents == value)
				{
					return;
				}
				_musicEvents = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get
			{
				if (_switches == null)
				{
					_switches = (CArray<audioAudSwitch>) CR2WTypeManager.Create("array:audioAudSwitch", "switches", cr2w, this);
				}
				return _switches;
			}
			set
			{
				if (_switches == value)
				{
					return;
				}
				_switches = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("params")] 
		public CArray<audioAudParameter> Params
		{
			get
			{
				if (_params == null)
				{
					_params = (CArray<audioAudParameter>) CR2WTypeManager.Create("array:audioAudParameter", "params", cr2w, this);
				}
				return _params;
			}
			set
			{
				if (_params == value)
				{
					return;
				}
				_params = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("dynamicParams")] 
		public CArray<CName> DynamicParams
		{
			get
			{
				if (_dynamicParams == null)
				{
					_dynamicParams = (CArray<CName>) CR2WTypeManager.Create("array:CName", "dynamicParams", cr2w, this);
				}
				return _dynamicParams;
			}
			set
			{
				if (_dynamicParams == value)
				{
					return;
				}
				_dynamicParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("event")] 
		public audioAudEventStruct Event
		{
			get
			{
				if (_event == null)
				{
					_event = (audioAudEventStruct) CR2WTypeManager.Create("audioAudEventStruct", "event", cr2w, this);
				}
				return _event;
			}
			set
			{
				if (_event == value)
				{
					return;
				}
				_event = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("ambientUniqueName")] 
		public CName AmbientUniqueName
		{
			get
			{
				if (_ambientUniqueName == null)
				{
					_ambientUniqueName = (CName) CR2WTypeManager.Create("CName", "ambientUniqueName", cr2w, this);
				}
				return _ambientUniqueName;
			}
			set
			{
				if (_ambientUniqueName == value)
				{
					return;
				}
				_ambientUniqueName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("emitter")] 
		public CName Emitter
		{
			get
			{
				if (_emitter == null)
				{
					_emitter = (CName) CR2WTypeManager.Create("CName", "emitter", cr2w, this);
				}
				return _emitter;
			}
			set
			{
				if (_emitter == value)
				{
					return;
				}
				_emitter = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("isMusic")] 
		public CBool IsMusic
		{
			get
			{
				if (_isMusic == null)
				{
					_isMusic = (CBool) CR2WTypeManager.Create("Bool", "isMusic", cr2w, this);
				}
				return _isMusic;
			}
			set
			{
				if (_isMusic == value)
				{
					return;
				}
				_isMusic = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get
			{
				if (_isPlayer == null)
				{
					_isPlayer = (CBool) CR2WTypeManager.Create("Bool", "isPlayer", cr2w, this);
				}
				return _isPlayer;
			}
			set
			{
				if (_isPlayer == value)
				{
					return;
				}
				_isPlayer = value;
				PropertySet(this);
			}
		}

		public questAudioEventNodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
