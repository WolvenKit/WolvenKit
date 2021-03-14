using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CityLightSystem : gameScriptableSystem
	{
		private CArray<CHandle<TimetableCallbackData>> _timeSystemCallbacks;
		private CArray<FuseData> _fuses;
		private CEnum<ECLSForcedState> _state;
		private CName _forcedStateSource;
		private CArray<ForcedStateData> _forcedStatesStack;
		private CHandle<CLSWeatherListener> _weatherListener;
		private CName _turnOffLisenerID;
		private CName _turnOnLisenerID;
		private CName _resetLisenerID;
		private CUInt32 _weatherCallbackId;

		[Ordinal(0)] 
		[RED("timeSystemCallbacks")] 
		public CArray<CHandle<TimetableCallbackData>> TimeSystemCallbacks
		{
			get
			{
				if (_timeSystemCallbacks == null)
				{
					_timeSystemCallbacks = (CArray<CHandle<TimetableCallbackData>>) CR2WTypeManager.Create("array:handle:TimetableCallbackData", "timeSystemCallbacks", cr2w, this);
				}
				return _timeSystemCallbacks;
			}
			set
			{
				if (_timeSystemCallbacks == value)
				{
					return;
				}
				_timeSystemCallbacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("fuses")] 
		public CArray<FuseData> Fuses
		{
			get
			{
				if (_fuses == null)
				{
					_fuses = (CArray<FuseData>) CR2WTypeManager.Create("array:FuseData", "fuses", cr2w, this);
				}
				return _fuses;
			}
			set
			{
				if (_fuses == value)
				{
					return;
				}
				_fuses = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<ECLSForcedState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<ECLSForcedState>) CR2WTypeManager.Create("ECLSForcedState", "state", cr2w, this);
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

		[Ordinal(3)] 
		[RED("forcedStateSource")] 
		public CName ForcedStateSource
		{
			get
			{
				if (_forcedStateSource == null)
				{
					_forcedStateSource = (CName) CR2WTypeManager.Create("CName", "forcedStateSource", cr2w, this);
				}
				return _forcedStateSource;
			}
			set
			{
				if (_forcedStateSource == value)
				{
					return;
				}
				_forcedStateSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("forcedStatesStack")] 
		public CArray<ForcedStateData> ForcedStatesStack
		{
			get
			{
				if (_forcedStatesStack == null)
				{
					_forcedStatesStack = (CArray<ForcedStateData>) CR2WTypeManager.Create("array:ForcedStateData", "forcedStatesStack", cr2w, this);
				}
				return _forcedStatesStack;
			}
			set
			{
				if (_forcedStatesStack == value)
				{
					return;
				}
				_forcedStatesStack = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("weatherListener")] 
		public CHandle<CLSWeatherListener> WeatherListener
		{
			get
			{
				if (_weatherListener == null)
				{
					_weatherListener = (CHandle<CLSWeatherListener>) CR2WTypeManager.Create("handle:CLSWeatherListener", "weatherListener", cr2w, this);
				}
				return _weatherListener;
			}
			set
			{
				if (_weatherListener == value)
				{
					return;
				}
				_weatherListener = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("turnOffLisenerID")] 
		public CName TurnOffLisenerID
		{
			get
			{
				if (_turnOffLisenerID == null)
				{
					_turnOffLisenerID = (CName) CR2WTypeManager.Create("CName", "turnOffLisenerID", cr2w, this);
				}
				return _turnOffLisenerID;
			}
			set
			{
				if (_turnOffLisenerID == value)
				{
					return;
				}
				_turnOffLisenerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("turnOnLisenerID")] 
		public CName TurnOnLisenerID
		{
			get
			{
				if (_turnOnLisenerID == null)
				{
					_turnOnLisenerID = (CName) CR2WTypeManager.Create("CName", "turnOnLisenerID", cr2w, this);
				}
				return _turnOnLisenerID;
			}
			set
			{
				if (_turnOnLisenerID == value)
				{
					return;
				}
				_turnOnLisenerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("resetLisenerID")] 
		public CName ResetLisenerID
		{
			get
			{
				if (_resetLisenerID == null)
				{
					_resetLisenerID = (CName) CR2WTypeManager.Create("CName", "resetLisenerID", cr2w, this);
				}
				return _resetLisenerID;
			}
			set
			{
				if (_resetLisenerID == value)
				{
					return;
				}
				_resetLisenerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("weatherCallbackId")] 
		public CUInt32 WeatherCallbackId
		{
			get
			{
				if (_weatherCallbackId == null)
				{
					_weatherCallbackId = (CUInt32) CR2WTypeManager.Create("Uint32", "weatherCallbackId", cr2w, this);
				}
				return _weatherCallbackId;
			}
			set
			{
				if (_weatherCallbackId == value)
				{
					return;
				}
				_weatherCallbackId = value;
				PropertySet(this);
			}
		}

		public CityLightSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
