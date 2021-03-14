using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioReflectionEmitterSettings : audioAudioMetadata
	{
		private CName _reflectionEvent;
		private CFloat _fadeout;
		private CFloat _reflectionDeltaThreshold;
		private CUInt32 _maxConcurrentReflections;
		private CUInt32 _broadcastChannel;
		private CBool _listenerRelativePosition;
		private CBool _upReflectionEnabled;
		private CBool _shortReflectionIndoors;
		private CEnum<audioReflectionVariant> _reflectionVariant;
		private CFloat _backReflectionCutoffSpread;
		private CFloat _backReflectionCutoffStrength;
		private CFloat _backReflectionCutoffSoftness;
		private CFloat _farReflectionDistance;
		private CFloat _nearReflectionDistance;
		private CFloat _minimumFaceAlignement;
		private CFloat _fixedRaycastPitch;

		[Ordinal(1)] 
		[RED("reflectionEvent")] 
		public CName ReflectionEvent
		{
			get
			{
				if (_reflectionEvent == null)
				{
					_reflectionEvent = (CName) CR2WTypeManager.Create("CName", "reflectionEvent", cr2w, this);
				}
				return _reflectionEvent;
			}
			set
			{
				if (_reflectionEvent == value)
				{
					return;
				}
				_reflectionEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("fadeout")] 
		public CFloat Fadeout
		{
			get
			{
				if (_fadeout == null)
				{
					_fadeout = (CFloat) CR2WTypeManager.Create("Float", "fadeout", cr2w, this);
				}
				return _fadeout;
			}
			set
			{
				if (_fadeout == value)
				{
					return;
				}
				_fadeout = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("reflectionDeltaThreshold")] 
		public CFloat ReflectionDeltaThreshold
		{
			get
			{
				if (_reflectionDeltaThreshold == null)
				{
					_reflectionDeltaThreshold = (CFloat) CR2WTypeManager.Create("Float", "reflectionDeltaThreshold", cr2w, this);
				}
				return _reflectionDeltaThreshold;
			}
			set
			{
				if (_reflectionDeltaThreshold == value)
				{
					return;
				}
				_reflectionDeltaThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("maxConcurrentReflections")] 
		public CUInt32 MaxConcurrentReflections
		{
			get
			{
				if (_maxConcurrentReflections == null)
				{
					_maxConcurrentReflections = (CUInt32) CR2WTypeManager.Create("Uint32", "maxConcurrentReflections", cr2w, this);
				}
				return _maxConcurrentReflections;
			}
			set
			{
				if (_maxConcurrentReflections == value)
				{
					return;
				}
				_maxConcurrentReflections = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("broadcastChannel")] 
		public CUInt32 BroadcastChannel
		{
			get
			{
				if (_broadcastChannel == null)
				{
					_broadcastChannel = (CUInt32) CR2WTypeManager.Create("Uint32", "broadcastChannel", cr2w, this);
				}
				return _broadcastChannel;
			}
			set
			{
				if (_broadcastChannel == value)
				{
					return;
				}
				_broadcastChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("listenerRelativePosition")] 
		public CBool ListenerRelativePosition
		{
			get
			{
				if (_listenerRelativePosition == null)
				{
					_listenerRelativePosition = (CBool) CR2WTypeManager.Create("Bool", "listenerRelativePosition", cr2w, this);
				}
				return _listenerRelativePosition;
			}
			set
			{
				if (_listenerRelativePosition == value)
				{
					return;
				}
				_listenerRelativePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("upReflectionEnabled")] 
		public CBool UpReflectionEnabled
		{
			get
			{
				if (_upReflectionEnabled == null)
				{
					_upReflectionEnabled = (CBool) CR2WTypeManager.Create("Bool", "upReflectionEnabled", cr2w, this);
				}
				return _upReflectionEnabled;
			}
			set
			{
				if (_upReflectionEnabled == value)
				{
					return;
				}
				_upReflectionEnabled = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("shortReflectionIndoors")] 
		public CBool ShortReflectionIndoors
		{
			get
			{
				if (_shortReflectionIndoors == null)
				{
					_shortReflectionIndoors = (CBool) CR2WTypeManager.Create("Bool", "shortReflectionIndoors", cr2w, this);
				}
				return _shortReflectionIndoors;
			}
			set
			{
				if (_shortReflectionIndoors == value)
				{
					return;
				}
				_shortReflectionIndoors = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("reflectionVariant")] 
		public CEnum<audioReflectionVariant> ReflectionVariant
		{
			get
			{
				if (_reflectionVariant == null)
				{
					_reflectionVariant = (CEnum<audioReflectionVariant>) CR2WTypeManager.Create("audioReflectionVariant", "reflectionVariant", cr2w, this);
				}
				return _reflectionVariant;
			}
			set
			{
				if (_reflectionVariant == value)
				{
					return;
				}
				_reflectionVariant = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("backReflectionCutoffSpread")] 
		public CFloat BackReflectionCutoffSpread
		{
			get
			{
				if (_backReflectionCutoffSpread == null)
				{
					_backReflectionCutoffSpread = (CFloat) CR2WTypeManager.Create("Float", "backReflectionCutoffSpread", cr2w, this);
				}
				return _backReflectionCutoffSpread;
			}
			set
			{
				if (_backReflectionCutoffSpread == value)
				{
					return;
				}
				_backReflectionCutoffSpread = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("backReflectionCutoffStrength")] 
		public CFloat BackReflectionCutoffStrength
		{
			get
			{
				if (_backReflectionCutoffStrength == null)
				{
					_backReflectionCutoffStrength = (CFloat) CR2WTypeManager.Create("Float", "backReflectionCutoffStrength", cr2w, this);
				}
				return _backReflectionCutoffStrength;
			}
			set
			{
				if (_backReflectionCutoffStrength == value)
				{
					return;
				}
				_backReflectionCutoffStrength = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("backReflectionCutoffSoftness")] 
		public CFloat BackReflectionCutoffSoftness
		{
			get
			{
				if (_backReflectionCutoffSoftness == null)
				{
					_backReflectionCutoffSoftness = (CFloat) CR2WTypeManager.Create("Float", "backReflectionCutoffSoftness", cr2w, this);
				}
				return _backReflectionCutoffSoftness;
			}
			set
			{
				if (_backReflectionCutoffSoftness == value)
				{
					return;
				}
				_backReflectionCutoffSoftness = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("farReflectionDistance")] 
		public CFloat FarReflectionDistance
		{
			get
			{
				if (_farReflectionDistance == null)
				{
					_farReflectionDistance = (CFloat) CR2WTypeManager.Create("Float", "farReflectionDistance", cr2w, this);
				}
				return _farReflectionDistance;
			}
			set
			{
				if (_farReflectionDistance == value)
				{
					return;
				}
				_farReflectionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("nearReflectionDistance")] 
		public CFloat NearReflectionDistance
		{
			get
			{
				if (_nearReflectionDistance == null)
				{
					_nearReflectionDistance = (CFloat) CR2WTypeManager.Create("Float", "nearReflectionDistance", cr2w, this);
				}
				return _nearReflectionDistance;
			}
			set
			{
				if (_nearReflectionDistance == value)
				{
					return;
				}
				_nearReflectionDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("minimumFaceAlignement")] 
		public CFloat MinimumFaceAlignement
		{
			get
			{
				if (_minimumFaceAlignement == null)
				{
					_minimumFaceAlignement = (CFloat) CR2WTypeManager.Create("Float", "minimumFaceAlignement", cr2w, this);
				}
				return _minimumFaceAlignement;
			}
			set
			{
				if (_minimumFaceAlignement == value)
				{
					return;
				}
				_minimumFaceAlignement = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("fixedRaycastPitch")] 
		public CFloat FixedRaycastPitch
		{
			get
			{
				if (_fixedRaycastPitch == null)
				{
					_fixedRaycastPitch = (CFloat) CR2WTypeManager.Create("Float", "fixedRaycastPitch", cr2w, this);
				}
				return _fixedRaycastPitch;
			}
			set
			{
				if (_fixedRaycastPitch == value)
				{
					return;
				}
				_fixedRaycastPitch = value;
				PropertySet(this);
			}
		}

		public audioReflectionEmitterSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
