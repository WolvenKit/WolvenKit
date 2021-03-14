using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatusEffect : gameStatusEffectBase
	{
		private CUInt32 _durationID;
		private CArray<CHandle<gameStatModifierData>> _durationModifiers;
		private CArray<CHandle<gameStatModifierData>> _stackModifiers;
		private CArray<CHandle<gameStatModifierData>> _removeAllStacksWhenDurationEndsModifiers;
		private CFloat _duration;
		private CFloat _remainingDuration;
		private CUInt32 _maxStacks;
		private CArray<gameSourceData> _sourcesData;
		private CFloat _initialApplicationTimestamp;
		private CFloat _lastApplicationTimestamp;
		private entEntityID _ownerEntityID;
		private TweakDBID _instigatorRecordID;
		private entEntityID _instigatorEntityID;
		private Vector4 _direction;
		private CBool _removeAllStacksWhenDurationEnds;
		private CName _applicationSource;

		[Ordinal(1)] 
		[RED("durationID")] 
		public CUInt32 DurationID
		{
			get
			{
				if (_durationID == null)
				{
					_durationID = (CUInt32) CR2WTypeManager.Create("Uint32", "durationID", cr2w, this);
				}
				return _durationID;
			}
			set
			{
				if (_durationID == value)
				{
					return;
				}
				_durationID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("durationModifiers")] 
		public CArray<CHandle<gameStatModifierData>> DurationModifiers
		{
			get
			{
				if (_durationModifiers == null)
				{
					_durationModifiers = (CArray<CHandle<gameStatModifierData>>) CR2WTypeManager.Create("array:handle:gameStatModifierData", "durationModifiers", cr2w, this);
				}
				return _durationModifiers;
			}
			set
			{
				if (_durationModifiers == value)
				{
					return;
				}
				_durationModifiers = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("stackModifiers")] 
		public CArray<CHandle<gameStatModifierData>> StackModifiers
		{
			get
			{
				if (_stackModifiers == null)
				{
					_stackModifiers = (CArray<CHandle<gameStatModifierData>>) CR2WTypeManager.Create("array:handle:gameStatModifierData", "stackModifiers", cr2w, this);
				}
				return _stackModifiers;
			}
			set
			{
				if (_stackModifiers == value)
				{
					return;
				}
				_stackModifiers = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("removeAllStacksWhenDurationEndsModifiers")] 
		public CArray<CHandle<gameStatModifierData>> RemoveAllStacksWhenDurationEndsModifiers
		{
			get
			{
				if (_removeAllStacksWhenDurationEndsModifiers == null)
				{
					_removeAllStacksWhenDurationEndsModifiers = (CArray<CHandle<gameStatModifierData>>) CR2WTypeManager.Create("array:handle:gameStatModifierData", "removeAllStacksWhenDurationEndsModifiers", cr2w, this);
				}
				return _removeAllStacksWhenDurationEndsModifiers;
			}
			set
			{
				if (_removeAllStacksWhenDurationEndsModifiers == value)
				{
					return;
				}
				_removeAllStacksWhenDurationEndsModifiers = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get
			{
				if (_duration == null)
				{
					_duration = (CFloat) CR2WTypeManager.Create("Float", "duration", cr2w, this);
				}
				return _duration;
			}
			set
			{
				if (_duration == value)
				{
					return;
				}
				_duration = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("remainingDuration")] 
		public CFloat RemainingDuration
		{
			get
			{
				if (_remainingDuration == null)
				{
					_remainingDuration = (CFloat) CR2WTypeManager.Create("Float", "remainingDuration", cr2w, this);
				}
				return _remainingDuration;
			}
			set
			{
				if (_remainingDuration == value)
				{
					return;
				}
				_remainingDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("maxStacks")] 
		public CUInt32 MaxStacks
		{
			get
			{
				if (_maxStacks == null)
				{
					_maxStacks = (CUInt32) CR2WTypeManager.Create("Uint32", "maxStacks", cr2w, this);
				}
				return _maxStacks;
			}
			set
			{
				if (_maxStacks == value)
				{
					return;
				}
				_maxStacks = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("sourcesData")] 
		public CArray<gameSourceData> SourcesData
		{
			get
			{
				if (_sourcesData == null)
				{
					_sourcesData = (CArray<gameSourceData>) CR2WTypeManager.Create("array:gameSourceData", "sourcesData", cr2w, this);
				}
				return _sourcesData;
			}
			set
			{
				if (_sourcesData == value)
				{
					return;
				}
				_sourcesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("initialApplicationTimestamp")] 
		public CFloat InitialApplicationTimestamp
		{
			get
			{
				if (_initialApplicationTimestamp == null)
				{
					_initialApplicationTimestamp = (CFloat) CR2WTypeManager.Create("Float", "initialApplicationTimestamp", cr2w, this);
				}
				return _initialApplicationTimestamp;
			}
			set
			{
				if (_initialApplicationTimestamp == value)
				{
					return;
				}
				_initialApplicationTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("lastApplicationTimestamp")] 
		public CFloat LastApplicationTimestamp
		{
			get
			{
				if (_lastApplicationTimestamp == null)
				{
					_lastApplicationTimestamp = (CFloat) CR2WTypeManager.Create("Float", "lastApplicationTimestamp", cr2w, this);
				}
				return _lastApplicationTimestamp;
			}
			set
			{
				if (_lastApplicationTimestamp == value)
				{
					return;
				}
				_lastApplicationTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("ownerEntityID")] 
		public entEntityID OwnerEntityID
		{
			get
			{
				if (_ownerEntityID == null)
				{
					_ownerEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerEntityID", cr2w, this);
				}
				return _ownerEntityID;
			}
			set
			{
				if (_ownerEntityID == value)
				{
					return;
				}
				_ownerEntityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("instigatorRecordID")] 
		public TweakDBID InstigatorRecordID
		{
			get
			{
				if (_instigatorRecordID == null)
				{
					_instigatorRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "instigatorRecordID", cr2w, this);
				}
				return _instigatorRecordID;
			}
			set
			{
				if (_instigatorRecordID == value)
				{
					return;
				}
				_instigatorRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("instigatorEntityID")] 
		public entEntityID InstigatorEntityID
		{
			get
			{
				if (_instigatorEntityID == null)
				{
					_instigatorEntityID = (entEntityID) CR2WTypeManager.Create("entEntityID", "instigatorEntityID", cr2w, this);
				}
				return _instigatorEntityID;
			}
			set
			{
				if (_instigatorEntityID == value)
				{
					return;
				}
				_instigatorEntityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("direction")] 
		public Vector4 Direction
		{
			get
			{
				if (_direction == null)
				{
					_direction = (Vector4) CR2WTypeManager.Create("Vector4", "direction", cr2w, this);
				}
				return _direction;
			}
			set
			{
				if (_direction == value)
				{
					return;
				}
				_direction = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("removeAllStacksWhenDurationEnds")] 
		public CBool RemoveAllStacksWhenDurationEnds
		{
			get
			{
				if (_removeAllStacksWhenDurationEnds == null)
				{
					_removeAllStacksWhenDurationEnds = (CBool) CR2WTypeManager.Create("Bool", "removeAllStacksWhenDurationEnds", cr2w, this);
				}
				return _removeAllStacksWhenDurationEnds;
			}
			set
			{
				if (_removeAllStacksWhenDurationEnds == value)
				{
					return;
				}
				_removeAllStacksWhenDurationEnds = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("applicationSource")] 
		public CName ApplicationSource
		{
			get
			{
				if (_applicationSource == null)
				{
					_applicationSource = (CName) CR2WTypeManager.Create("CName", "applicationSource", cr2w, this);
				}
				return _applicationSource;
			}
			set
			{
				if (_applicationSource == value)
				{
					return;
				}
				_applicationSource = value;
				PropertySet(this);
			}
		}

		public gameStatusEffect(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
