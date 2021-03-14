using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAcousticZoneMetadata : audioAudioMetadata
	{
		private CInt32 _priority;
		private CFloat _bleadingDistance;
		private CArray<CName> _eventsOnEnter;
		private CArray<CName> _eventsOnExit;
		private CArray<CName> _eventsOnActive;
		private CArray<CName> _soundBanks;
		private CArray<audioAcousticZoneParameterMapItem> _parameters;
		private CName _reverbSettings;
		private CName _voReverbSettings;
		private CName _footstepMaterialOverride;

		[Ordinal(1)] 
		[RED("priority")] 
		public CInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CInt32) CR2WTypeManager.Create("Int32", "priority", cr2w, this);
				}
				return _priority;
			}
			set
			{
				if (_priority == value)
				{
					return;
				}
				_priority = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("bleadingDistance")] 
		public CFloat BleadingDistance
		{
			get
			{
				if (_bleadingDistance == null)
				{
					_bleadingDistance = (CFloat) CR2WTypeManager.Create("Float", "bleadingDistance", cr2w, this);
				}
				return _bleadingDistance;
			}
			set
			{
				if (_bleadingDistance == value)
				{
					return;
				}
				_bleadingDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("eventsOnEnter")] 
		public CArray<CName> EventsOnEnter
		{
			get
			{
				if (_eventsOnEnter == null)
				{
					_eventsOnEnter = (CArray<CName>) CR2WTypeManager.Create("array:CName", "eventsOnEnter", cr2w, this);
				}
				return _eventsOnEnter;
			}
			set
			{
				if (_eventsOnEnter == value)
				{
					return;
				}
				_eventsOnEnter = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("eventsOnExit")] 
		public CArray<CName> EventsOnExit
		{
			get
			{
				if (_eventsOnExit == null)
				{
					_eventsOnExit = (CArray<CName>) CR2WTypeManager.Create("array:CName", "eventsOnExit", cr2w, this);
				}
				return _eventsOnExit;
			}
			set
			{
				if (_eventsOnExit == value)
				{
					return;
				}
				_eventsOnExit = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("eventsOnActive")] 
		public CArray<CName> EventsOnActive
		{
			get
			{
				if (_eventsOnActive == null)
				{
					_eventsOnActive = (CArray<CName>) CR2WTypeManager.Create("array:CName", "eventsOnActive", cr2w, this);
				}
				return _eventsOnActive;
			}
			set
			{
				if (_eventsOnActive == value)
				{
					return;
				}
				_eventsOnActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("soundBanks")] 
		public CArray<CName> SoundBanks
		{
			get
			{
				if (_soundBanks == null)
				{
					_soundBanks = (CArray<CName>) CR2WTypeManager.Create("array:CName", "soundBanks", cr2w, this);
				}
				return _soundBanks;
			}
			set
			{
				if (_soundBanks == value)
				{
					return;
				}
				_soundBanks = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("parameters")] 
		public CArray<audioAcousticZoneParameterMapItem> Parameters
		{
			get
			{
				if (_parameters == null)
				{
					_parameters = (CArray<audioAcousticZoneParameterMapItem>) CR2WTypeManager.Create("array:audioAcousticZoneParameterMapItem", "parameters", cr2w, this);
				}
				return _parameters;
			}
			set
			{
				if (_parameters == value)
				{
					return;
				}
				_parameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("reverbSettings")] 
		public CName ReverbSettings
		{
			get
			{
				if (_reverbSettings == null)
				{
					_reverbSettings = (CName) CR2WTypeManager.Create("CName", "reverbSettings", cr2w, this);
				}
				return _reverbSettings;
			}
			set
			{
				if (_reverbSettings == value)
				{
					return;
				}
				_reverbSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("voReverbSettings")] 
		public CName VoReverbSettings
		{
			get
			{
				if (_voReverbSettings == null)
				{
					_voReverbSettings = (CName) CR2WTypeManager.Create("CName", "voReverbSettings", cr2w, this);
				}
				return _voReverbSettings;
			}
			set
			{
				if (_voReverbSettings == value)
				{
					return;
				}
				_voReverbSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("footstepMaterialOverride")] 
		public CName FootstepMaterialOverride
		{
			get
			{
				if (_footstepMaterialOverride == null)
				{
					_footstepMaterialOverride = (CName) CR2WTypeManager.Create("CName", "footstepMaterialOverride", cr2w, this);
				}
				return _footstepMaterialOverride;
			}
			set
			{
				if (_footstepMaterialOverride == value)
				{
					return;
				}
				_footstepMaterialOverride = value;
				PropertySet(this);
			}
		}

		public audioAcousticZoneMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
