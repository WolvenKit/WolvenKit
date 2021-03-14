using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TransformToTrack : animAnimNode_OnePoseInput
	{
		private CInt32 _floatTrack;
		private animNamedTrackIndex _floatTrackIndex;
		private CInt16 _outputTransform;
		private animTransformIndex _transformIndex;
		private CEnum<animTransformChannel> _channel;
		private CFloat _mulFactor;
		private CFloat _weight;
		private animFloatLink _weightNode;
		private animFloatLink _mulFactorNode;

		[Ordinal(12)] 
		[RED("floatTrack")] 
		public CInt32 FloatTrack
		{
			get
			{
				if (_floatTrack == null)
				{
					_floatTrack = (CInt32) CR2WTypeManager.Create("Int32", "floatTrack", cr2w, this);
				}
				return _floatTrack;
			}
			set
			{
				if (_floatTrack == value)
				{
					return;
				}
				_floatTrack = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("floatTrackIndex")] 
		public animNamedTrackIndex FloatTrackIndex
		{
			get
			{
				if (_floatTrackIndex == null)
				{
					_floatTrackIndex = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "floatTrackIndex", cr2w, this);
				}
				return _floatTrackIndex;
			}
			set
			{
				if (_floatTrackIndex == value)
				{
					return;
				}
				_floatTrackIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("outputTransform")] 
		public CInt16 OutputTransform
		{
			get
			{
				if (_outputTransform == null)
				{
					_outputTransform = (CInt16) CR2WTypeManager.Create("Int16", "outputTransform", cr2w, this);
				}
				return _outputTransform;
			}
			set
			{
				if (_outputTransform == value)
				{
					return;
				}
				_outputTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get
			{
				if (_transformIndex == null)
				{
					_transformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "transformIndex", cr2w, this);
				}
				return _transformIndex;
			}
			set
			{
				if (_transformIndex == value)
				{
					return;
				}
				_transformIndex = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("channel")] 
		public CEnum<animTransformChannel> Channel
		{
			get
			{
				if (_channel == null)
				{
					_channel = (CEnum<animTransformChannel>) CR2WTypeManager.Create("animTransformChannel", "channel", cr2w, this);
				}
				return _channel;
			}
			set
			{
				if (_channel == value)
				{
					return;
				}
				_channel = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("mulFactor")] 
		public CFloat MulFactor
		{
			get
			{
				if (_mulFactor == null)
				{
					_mulFactor = (CFloat) CR2WTypeManager.Create("Float", "mulFactor", cr2w, this);
				}
				return _mulFactor;
			}
			set
			{
				if (_mulFactor == value)
				{
					return;
				}
				_mulFactor = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get
			{
				if (_weight == null)
				{
					_weight = (CFloat) CR2WTypeManager.Create("Float", "weight", cr2w, this);
				}
				return _weight;
			}
			set
			{
				if (_weight == value)
				{
					return;
				}
				_weight = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get
			{
				if (_weightNode == null)
				{
					_weightNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "weightNode", cr2w, this);
				}
				return _weightNode;
			}
			set
			{
				if (_weightNode == value)
				{
					return;
				}
				_weightNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("mulFactorNode")] 
		public animFloatLink MulFactorNode
		{
			get
			{
				if (_mulFactorNode == null)
				{
					_mulFactorNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "mulFactorNode", cr2w, this);
				}
				return _mulFactorNode;
			}
			set
			{
				if (_mulFactorNode == value)
				{
					return;
				}
				_mulFactorNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_TransformToTrack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
