using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioDynamicReverbSettings : audioAudioMetadata
	{
		private CEnum<audioDynamicReverbType> _reverbType;
		private audioReverbCrossoverParams _crossover1;
		private audioReverbCrossoverParams _crossover2;
		private CFloat _maxDistance;
		private CName _smallReverb;
		private CFloat _smallReverbMaxDistance;
		private CFloat _smallReverbFadeOutThreshold;
		private CName _mediumReverb;
		private CName _largeReverb;
		private CName _vehicleReverb;
		private CBool _overrideWeaponTail;
		private CName _sourceBasedReverbSet;
		private CEnum<audioWeaponTailEnvironment> _weaponTailType;
		private CEnum<audioEchoPositionType> _echoPositionType;
		private CEnum<audioEchoPositionType> _reportPositionType;

		[Ordinal(1)] 
		[RED("reverbType")] 
		public CEnum<audioDynamicReverbType> ReverbType
		{
			get
			{
				if (_reverbType == null)
				{
					_reverbType = (CEnum<audioDynamicReverbType>) CR2WTypeManager.Create("audioDynamicReverbType", "reverbType", cr2w, this);
				}
				return _reverbType;
			}
			set
			{
				if (_reverbType == value)
				{
					return;
				}
				_reverbType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("crossover1")] 
		public audioReverbCrossoverParams Crossover1
		{
			get
			{
				if (_crossover1 == null)
				{
					_crossover1 = (audioReverbCrossoverParams) CR2WTypeManager.Create("audioReverbCrossoverParams", "crossover1", cr2w, this);
				}
				return _crossover1;
			}
			set
			{
				if (_crossover1 == value)
				{
					return;
				}
				_crossover1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("crossover2")] 
		public audioReverbCrossoverParams Crossover2
		{
			get
			{
				if (_crossover2 == null)
				{
					_crossover2 = (audioReverbCrossoverParams) CR2WTypeManager.Create("audioReverbCrossoverParams", "crossover2", cr2w, this);
				}
				return _crossover2;
			}
			set
			{
				if (_crossover2 == value)
				{
					return;
				}
				_crossover2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get
			{
				if (_maxDistance == null)
				{
					_maxDistance = (CFloat) CR2WTypeManager.Create("Float", "maxDistance", cr2w, this);
				}
				return _maxDistance;
			}
			set
			{
				if (_maxDistance == value)
				{
					return;
				}
				_maxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("smallReverb")] 
		public CName SmallReverb
		{
			get
			{
				if (_smallReverb == null)
				{
					_smallReverb = (CName) CR2WTypeManager.Create("CName", "smallReverb", cr2w, this);
				}
				return _smallReverb;
			}
			set
			{
				if (_smallReverb == value)
				{
					return;
				}
				_smallReverb = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("smallReverbMaxDistance")] 
		public CFloat SmallReverbMaxDistance
		{
			get
			{
				if (_smallReverbMaxDistance == null)
				{
					_smallReverbMaxDistance = (CFloat) CR2WTypeManager.Create("Float", "smallReverbMaxDistance", cr2w, this);
				}
				return _smallReverbMaxDistance;
			}
			set
			{
				if (_smallReverbMaxDistance == value)
				{
					return;
				}
				_smallReverbMaxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("smallReverbFadeOutThreshold")] 
		public CFloat SmallReverbFadeOutThreshold
		{
			get
			{
				if (_smallReverbFadeOutThreshold == null)
				{
					_smallReverbFadeOutThreshold = (CFloat) CR2WTypeManager.Create("Float", "smallReverbFadeOutThreshold", cr2w, this);
				}
				return _smallReverbFadeOutThreshold;
			}
			set
			{
				if (_smallReverbFadeOutThreshold == value)
				{
					return;
				}
				_smallReverbFadeOutThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("mediumReverb")] 
		public CName MediumReverb
		{
			get
			{
				if (_mediumReverb == null)
				{
					_mediumReverb = (CName) CR2WTypeManager.Create("CName", "mediumReverb", cr2w, this);
				}
				return _mediumReverb;
			}
			set
			{
				if (_mediumReverb == value)
				{
					return;
				}
				_mediumReverb = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("largeReverb")] 
		public CName LargeReverb
		{
			get
			{
				if (_largeReverb == null)
				{
					_largeReverb = (CName) CR2WTypeManager.Create("CName", "largeReverb", cr2w, this);
				}
				return _largeReverb;
			}
			set
			{
				if (_largeReverb == value)
				{
					return;
				}
				_largeReverb = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("vehicleReverb")] 
		public CName VehicleReverb
		{
			get
			{
				if (_vehicleReverb == null)
				{
					_vehicleReverb = (CName) CR2WTypeManager.Create("CName", "vehicleReverb", cr2w, this);
				}
				return _vehicleReverb;
			}
			set
			{
				if (_vehicleReverb == value)
				{
					return;
				}
				_vehicleReverb = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("overrideWeaponTail")] 
		public CBool OverrideWeaponTail
		{
			get
			{
				if (_overrideWeaponTail == null)
				{
					_overrideWeaponTail = (CBool) CR2WTypeManager.Create("Bool", "overrideWeaponTail", cr2w, this);
				}
				return _overrideWeaponTail;
			}
			set
			{
				if (_overrideWeaponTail == value)
				{
					return;
				}
				_overrideWeaponTail = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("sourceBasedReverbSet")] 
		public CName SourceBasedReverbSet
		{
			get
			{
				if (_sourceBasedReverbSet == null)
				{
					_sourceBasedReverbSet = (CName) CR2WTypeManager.Create("CName", "sourceBasedReverbSet", cr2w, this);
				}
				return _sourceBasedReverbSet;
			}
			set
			{
				if (_sourceBasedReverbSet == value)
				{
					return;
				}
				_sourceBasedReverbSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("weaponTailType")] 
		public CEnum<audioWeaponTailEnvironment> WeaponTailType
		{
			get
			{
				if (_weaponTailType == null)
				{
					_weaponTailType = (CEnum<audioWeaponTailEnvironment>) CR2WTypeManager.Create("audioWeaponTailEnvironment", "weaponTailType", cr2w, this);
				}
				return _weaponTailType;
			}
			set
			{
				if (_weaponTailType == value)
				{
					return;
				}
				_weaponTailType = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("echoPositionType")] 
		public CEnum<audioEchoPositionType> EchoPositionType
		{
			get
			{
				if (_echoPositionType == null)
				{
					_echoPositionType = (CEnum<audioEchoPositionType>) CR2WTypeManager.Create("audioEchoPositionType", "echoPositionType", cr2w, this);
				}
				return _echoPositionType;
			}
			set
			{
				if (_echoPositionType == value)
				{
					return;
				}
				_echoPositionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("reportPositionType")] 
		public CEnum<audioEchoPositionType> ReportPositionType
		{
			get
			{
				if (_reportPositionType == null)
				{
					_reportPositionType = (CEnum<audioEchoPositionType>) CR2WTypeManager.Create("audioEchoPositionType", "reportPositionType", cr2w, this);
				}
				return _reportPositionType;
			}
			set
			{
				if (_reportPositionType == value)
				{
					return;
				}
				_reportPositionType = value;
				PropertySet(this);
			}
		}

		public audioDynamicReverbSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
