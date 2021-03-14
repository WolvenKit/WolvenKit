using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SimpleBounce : animAnimNode_OnePoseInput
	{
		private CBool _areChannelsResaved;
		private animNamedTrackIndex _outputDriverTrack;
		private CBool _debug;
		private animTransformIndex _startTransform;
		private animTransformIndex _endTransform;
		private CFloat _multiplier;
		private CFloat _negativeMultiplier;
		private CFloat _smoothStep;
		private CFloat _offset;
		private CFloat _delay;
		private CArray<animSimpleBounceTransformOutput> _transformOutputs;
		private CArray<animSimpleBounceTrackOutput> _trackOutputs;

		[Ordinal(12)] 
		[RED("areChannelsResaved")] 
		public CBool AreChannelsResaved
		{
			get
			{
				if (_areChannelsResaved == null)
				{
					_areChannelsResaved = (CBool) CR2WTypeManager.Create("Bool", "areChannelsResaved", cr2w, this);
				}
				return _areChannelsResaved;
			}
			set
			{
				if (_areChannelsResaved == value)
				{
					return;
				}
				_areChannelsResaved = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("outputDriverTrack")] 
		public animNamedTrackIndex OutputDriverTrack
		{
			get
			{
				if (_outputDriverTrack == null)
				{
					_outputDriverTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "outputDriverTrack", cr2w, this);
				}
				return _outputDriverTrack;
			}
			set
			{
				if (_outputDriverTrack == value)
				{
					return;
				}
				_outputDriverTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("debug")] 
		public CBool Debug
		{
			get
			{
				if (_debug == null)
				{
					_debug = (CBool) CR2WTypeManager.Create("Bool", "debug", cr2w, this);
				}
				return _debug;
			}
			set
			{
				if (_debug == value)
				{
					return;
				}
				_debug = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("startTransform")] 
		public animTransformIndex StartTransform
		{
			get
			{
				if (_startTransform == null)
				{
					_startTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "startTransform", cr2w, this);
				}
				return _startTransform;
			}
			set
			{
				if (_startTransform == value)
				{
					return;
				}
				_startTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("endTransform")] 
		public animTransformIndex EndTransform
		{
			get
			{
				if (_endTransform == null)
				{
					_endTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "endTransform", cr2w, this);
				}
				return _endTransform;
			}
			set
			{
				if (_endTransform == value)
				{
					return;
				}
				_endTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("multiplier")] 
		public CFloat Multiplier
		{
			get
			{
				if (_multiplier == null)
				{
					_multiplier = (CFloat) CR2WTypeManager.Create("Float", "multiplier", cr2w, this);
				}
				return _multiplier;
			}
			set
			{
				if (_multiplier == value)
				{
					return;
				}
				_multiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("negativeMultiplier")] 
		public CFloat NegativeMultiplier
		{
			get
			{
				if (_negativeMultiplier == null)
				{
					_negativeMultiplier = (CFloat) CR2WTypeManager.Create("Float", "negativeMultiplier", cr2w, this);
				}
				return _negativeMultiplier;
			}
			set
			{
				if (_negativeMultiplier == value)
				{
					return;
				}
				_negativeMultiplier = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("smoothStep")] 
		public CFloat SmoothStep
		{
			get
			{
				if (_smoothStep == null)
				{
					_smoothStep = (CFloat) CR2WTypeManager.Create("Float", "smoothStep", cr2w, this);
				}
				return _smoothStep;
			}
			set
			{
				if (_smoothStep == value)
				{
					return;
				}
				_smoothStep = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("offset")] 
		public CFloat Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (CFloat) CR2WTypeManager.Create("Float", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get
			{
				if (_delay == null)
				{
					_delay = (CFloat) CR2WTypeManager.Create("Float", "delay", cr2w, this);
				}
				return _delay;
			}
			set
			{
				if (_delay == value)
				{
					return;
				}
				_delay = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("transformOutputs")] 
		public CArray<animSimpleBounceTransformOutput> TransformOutputs
		{
			get
			{
				if (_transformOutputs == null)
				{
					_transformOutputs = (CArray<animSimpleBounceTransformOutput>) CR2WTypeManager.Create("array:animSimpleBounceTransformOutput", "transformOutputs", cr2w, this);
				}
				return _transformOutputs;
			}
			set
			{
				if (_transformOutputs == value)
				{
					return;
				}
				_transformOutputs = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("trackOutputs")] 
		public CArray<animSimpleBounceTrackOutput> TrackOutputs
		{
			get
			{
				if (_trackOutputs == null)
				{
					_trackOutputs = (CArray<animSimpleBounceTrackOutput>) CR2WTypeManager.Create("array:animSimpleBounceTrackOutput", "trackOutputs", cr2w, this);
				}
				return _trackOutputs;
			}
			set
			{
				if (_trackOutputs == value)
				{
					return;
				}
				_trackOutputs = value;
				PropertySet(this);
			}
		}

		public animAnimNode_SimpleBounce(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
