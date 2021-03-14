using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioAmbientAreaSettings : audioAudioMetadata
	{
		private CName _metadataParent;
		private CName _emitterDecorator;
		private CInt32 _priority;
		private CArray<audioAudEventStruct> _eventsOnEnter;
		private CArray<audioAudEventStruct> _eventsOnExit;
		private CArray<audioAudEventStruct> _eventsOnActive;
		private CArray<audioSoundBankStruct> _soundBanks;
		private CArray<audioAudSwitch> _switches;
		private CArray<audioAudParameter> _parameters;
		private CName _reverb;
		private CFloat _reverbTransitionTime;
		private CName _voReverb;
		private CName _footstepMaterialOverride;
		private CBool _isMusic;
		private audioAmbientAreaGroupingSettings _groupingSettings;
		private audioQuadEmitterSettings _quadSettings;
		private CFloat _outerDistance;
		private CFloat _verticalOuterDistance;
		private CFloat _insideSourceDistance;
		private CName _eventOverrides;
		private CBool _outdoornessOverride;
		private CFloat _outdoorness;
		private CBool _mergeRoomsWithinArea;
		private CName _mixingContext;
		private CArray<audioAmbientPaletteEntry> _ambientPaletteEntries;

		[Ordinal(1)] 
		[RED("MetadataParent")] 
		public CName MetadataParent
		{
			get
			{
				if (_metadataParent == null)
				{
					_metadataParent = (CName) CR2WTypeManager.Create("CName", "MetadataParent", cr2w, this);
				}
				return _metadataParent;
			}
			set
			{
				if (_metadataParent == value)
				{
					return;
				}
				_metadataParent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("EmitterDecorator")] 
		public CName EmitterDecorator
		{
			get
			{
				if (_emitterDecorator == null)
				{
					_emitterDecorator = (CName) CR2WTypeManager.Create("CName", "EmitterDecorator", cr2w, this);
				}
				return _emitterDecorator;
			}
			set
			{
				if (_emitterDecorator == value)
				{
					return;
				}
				_emitterDecorator = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Priority")] 
		public CInt32 Priority
		{
			get
			{
				if (_priority == null)
				{
					_priority = (CInt32) CR2WTypeManager.Create("Int32", "Priority", cr2w, this);
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

		[Ordinal(4)] 
		[RED("EventsOnEnter")] 
		public CArray<audioAudEventStruct> EventsOnEnter
		{
			get
			{
				if (_eventsOnEnter == null)
				{
					_eventsOnEnter = (CArray<audioAudEventStruct>) CR2WTypeManager.Create("array:audioAudEventStruct", "EventsOnEnter", cr2w, this);
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

		[Ordinal(5)] 
		[RED("EventsOnExit")] 
		public CArray<audioAudEventStruct> EventsOnExit
		{
			get
			{
				if (_eventsOnExit == null)
				{
					_eventsOnExit = (CArray<audioAudEventStruct>) CR2WTypeManager.Create("array:audioAudEventStruct", "EventsOnExit", cr2w, this);
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

		[Ordinal(6)] 
		[RED("EventsOnActive")] 
		public CArray<audioAudEventStruct> EventsOnActive
		{
			get
			{
				if (_eventsOnActive == null)
				{
					_eventsOnActive = (CArray<audioAudEventStruct>) CR2WTypeManager.Create("array:audioAudEventStruct", "EventsOnActive", cr2w, this);
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

		[Ordinal(7)] 
		[RED("SoundBanks")] 
		public CArray<audioSoundBankStruct> SoundBanks
		{
			get
			{
				if (_soundBanks == null)
				{
					_soundBanks = (CArray<audioSoundBankStruct>) CR2WTypeManager.Create("array:audioSoundBankStruct", "SoundBanks", cr2w, this);
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

		[Ordinal(8)] 
		[RED("Switches")] 
		public CArray<audioAudSwitch> Switches
		{
			get
			{
				if (_switches == null)
				{
					_switches = (CArray<audioAudSwitch>) CR2WTypeManager.Create("array:audioAudSwitch", "Switches", cr2w, this);
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

		[Ordinal(9)] 
		[RED("Parameters")] 
		public CArray<audioAudParameter> Parameters
		{
			get
			{
				if (_parameters == null)
				{
					_parameters = (CArray<audioAudParameter>) CR2WTypeManager.Create("array:audioAudParameter", "Parameters", cr2w, this);
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

		[Ordinal(10)] 
		[RED("Reverb")] 
		public CName Reverb
		{
			get
			{
				if (_reverb == null)
				{
					_reverb = (CName) CR2WTypeManager.Create("CName", "Reverb", cr2w, this);
				}
				return _reverb;
			}
			set
			{
				if (_reverb == value)
				{
					return;
				}
				_reverb = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("reverbTransitionTime")] 
		public CFloat ReverbTransitionTime
		{
			get
			{
				if (_reverbTransitionTime == null)
				{
					_reverbTransitionTime = (CFloat) CR2WTypeManager.Create("Float", "reverbTransitionTime", cr2w, this);
				}
				return _reverbTransitionTime;
			}
			set
			{
				if (_reverbTransitionTime == value)
				{
					return;
				}
				_reverbTransitionTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("VoReverb")] 
		public CName VoReverb
		{
			get
			{
				if (_voReverb == null)
				{
					_voReverb = (CName) CR2WTypeManager.Create("CName", "VoReverb", cr2w, this);
				}
				return _voReverb;
			}
			set
			{
				if (_voReverb == value)
				{
					return;
				}
				_voReverb = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("FootstepMaterialOverride")] 
		public CName FootstepMaterialOverride
		{
			get
			{
				if (_footstepMaterialOverride == null)
				{
					_footstepMaterialOverride = (CName) CR2WTypeManager.Create("CName", "FootstepMaterialOverride", cr2w, this);
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("groupingSettings")] 
		public audioAmbientAreaGroupingSettings GroupingSettings
		{
			get
			{
				if (_groupingSettings == null)
				{
					_groupingSettings = (audioAmbientAreaGroupingSettings) CR2WTypeManager.Create("audioAmbientAreaGroupingSettings", "groupingSettings", cr2w, this);
				}
				return _groupingSettings;
			}
			set
			{
				if (_groupingSettings == value)
				{
					return;
				}
				_groupingSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("quadSettings")] 
		public audioQuadEmitterSettings QuadSettings
		{
			get
			{
				if (_quadSettings == null)
				{
					_quadSettings = (audioQuadEmitterSettings) CR2WTypeManager.Create("audioQuadEmitterSettings", "quadSettings", cr2w, this);
				}
				return _quadSettings;
			}
			set
			{
				if (_quadSettings == value)
				{
					return;
				}
				_quadSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("outerDistance")] 
		public CFloat OuterDistance
		{
			get
			{
				if (_outerDistance == null)
				{
					_outerDistance = (CFloat) CR2WTypeManager.Create("Float", "outerDistance", cr2w, this);
				}
				return _outerDistance;
			}
			set
			{
				if (_outerDistance == value)
				{
					return;
				}
				_outerDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("verticalOuterDistance")] 
		public CFloat VerticalOuterDistance
		{
			get
			{
				if (_verticalOuterDistance == null)
				{
					_verticalOuterDistance = (CFloat) CR2WTypeManager.Create("Float", "verticalOuterDistance", cr2w, this);
				}
				return _verticalOuterDistance;
			}
			set
			{
				if (_verticalOuterDistance == value)
				{
					return;
				}
				_verticalOuterDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("insideSourceDistance")] 
		public CFloat InsideSourceDistance
		{
			get
			{
				if (_insideSourceDistance == null)
				{
					_insideSourceDistance = (CFloat) CR2WTypeManager.Create("Float", "insideSourceDistance", cr2w, this);
				}
				return _insideSourceDistance;
			}
			set
			{
				if (_insideSourceDistance == value)
				{
					return;
				}
				_insideSourceDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("eventOverrides")] 
		public CName EventOverrides
		{
			get
			{
				if (_eventOverrides == null)
				{
					_eventOverrides = (CName) CR2WTypeManager.Create("CName", "eventOverrides", cr2w, this);
				}
				return _eventOverrides;
			}
			set
			{
				if (_eventOverrides == value)
				{
					return;
				}
				_eventOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("outdoornessOverride")] 
		public CBool OutdoornessOverride
		{
			get
			{
				if (_outdoornessOverride == null)
				{
					_outdoornessOverride = (CBool) CR2WTypeManager.Create("Bool", "outdoornessOverride", cr2w, this);
				}
				return _outdoornessOverride;
			}
			set
			{
				if (_outdoornessOverride == value)
				{
					return;
				}
				_outdoornessOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("outdoorness")] 
		public CFloat Outdoorness
		{
			get
			{
				if (_outdoorness == null)
				{
					_outdoorness = (CFloat) CR2WTypeManager.Create("Float", "outdoorness", cr2w, this);
				}
				return _outdoorness;
			}
			set
			{
				if (_outdoorness == value)
				{
					return;
				}
				_outdoorness = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("mergeRoomsWithinArea")] 
		public CBool MergeRoomsWithinArea
		{
			get
			{
				if (_mergeRoomsWithinArea == null)
				{
					_mergeRoomsWithinArea = (CBool) CR2WTypeManager.Create("Bool", "mergeRoomsWithinArea", cr2w, this);
				}
				return _mergeRoomsWithinArea;
			}
			set
			{
				if (_mergeRoomsWithinArea == value)
				{
					return;
				}
				_mergeRoomsWithinArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("mixingContext")] 
		public CName MixingContext
		{
			get
			{
				if (_mixingContext == null)
				{
					_mixingContext = (CName) CR2WTypeManager.Create("CName", "mixingContext", cr2w, this);
				}
				return _mixingContext;
			}
			set
			{
				if (_mixingContext == value)
				{
					return;
				}
				_mixingContext = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("ambientPaletteEntries")] 
		public CArray<audioAmbientPaletteEntry> AmbientPaletteEntries
		{
			get
			{
				if (_ambientPaletteEntries == null)
				{
					_ambientPaletteEntries = (CArray<audioAmbientPaletteEntry>) CR2WTypeManager.Create("array:audioAmbientPaletteEntry", "ambientPaletteEntries", cr2w, this);
				}
				return _ambientPaletteEntries;
			}
			set
			{
				if (_ambientPaletteEntries == value)
				{
					return;
				}
				_ambientPaletteEntries = value;
				PropertySet(this);
			}
		}

		public audioAmbientAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
