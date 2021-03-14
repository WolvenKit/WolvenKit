using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_AimConstraint : animAnimNode_OnePoseInput
	{
		private CBool _areSourceChannelsResaved;
		private CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> _targetTransforms;
		private animTransformIndex _targetTransform;
		private CHandle<animIAnimNodeSourceChannel_Vector> _upTransform;
		private animTransformIndex _transformIndex;
		private Vector3 _forwardAxisLS;
		private Vector3 _upAxisLS;
		private CEnum<animConstraintWeightMode> _weightMode;
		private CFloat _weight;
		private animNamedTrackIndex _weightFloatTrack;

		[Ordinal(12)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get
			{
				if (_areSourceChannelsResaved == null)
				{
					_areSourceChannelsResaved = (CBool) CR2WTypeManager.Create("Bool", "areSourceChannelsResaved", cr2w, this);
				}
				return _areSourceChannelsResaved;
			}
			set
			{
				if (_areSourceChannelsResaved == value)
				{
					return;
				}
				_areSourceChannelsResaved = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("targetTransforms")] 
		public CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> TargetTransforms
		{
			get
			{
				if (_targetTransforms == null)
				{
					_targetTransforms = (CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>>) CR2WTypeManager.Create("array:handle:animAnimNodeSourceChannel_WeightedVector", "targetTransforms", cr2w, this);
				}
				return _targetTransforms;
			}
			set
			{
				if (_targetTransforms == value)
				{
					return;
				}
				_targetTransforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("targetTransform")] 
		public animTransformIndex TargetTransform
		{
			get
			{
				if (_targetTransform == null)
				{
					_targetTransform = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "targetTransform", cr2w, this);
				}
				return _targetTransform;
			}
			set
			{
				if (_targetTransform == value)
				{
					return;
				}
				_targetTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("upTransform")] 
		public CHandle<animIAnimNodeSourceChannel_Vector> UpTransform
		{
			get
			{
				if (_upTransform == null)
				{
					_upTransform = (CHandle<animIAnimNodeSourceChannel_Vector>) CR2WTypeManager.Create("handle:animIAnimNodeSourceChannel_Vector", "upTransform", cr2w, this);
				}
				return _upTransform;
			}
			set
			{
				if (_upTransform == value)
				{
					return;
				}
				_upTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
		[RED("forwardAxisLS")] 
		public Vector3 ForwardAxisLS
		{
			get
			{
				if (_forwardAxisLS == null)
				{
					_forwardAxisLS = (Vector3) CR2WTypeManager.Create("Vector3", "forwardAxisLS", cr2w, this);
				}
				return _forwardAxisLS;
			}
			set
			{
				if (_forwardAxisLS == value)
				{
					return;
				}
				_forwardAxisLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("upAxisLS")] 
		public Vector3 UpAxisLS
		{
			get
			{
				if (_upAxisLS == null)
				{
					_upAxisLS = (Vector3) CR2WTypeManager.Create("Vector3", "upAxisLS", cr2w, this);
				}
				return _upAxisLS;
			}
			set
			{
				if (_upAxisLS == value)
				{
					return;
				}
				_upAxisLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get
			{
				if (_weightMode == null)
				{
					_weightMode = (CEnum<animConstraintWeightMode>) CR2WTypeManager.Create("animConstraintWeightMode", "weightMode", cr2w, this);
				}
				return _weightMode;
			}
			set
			{
				if (_weightMode == value)
				{
					return;
				}
				_weightMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
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

		[Ordinal(21)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get
			{
				if (_weightFloatTrack == null)
				{
					_weightFloatTrack = (animNamedTrackIndex) CR2WTypeManager.Create("animNamedTrackIndex", "weightFloatTrack", cr2w, this);
				}
				return _weightFloatTrack;
			}
			set
			{
				if (_weightFloatTrack == value)
				{
					return;
				}
				_weightFloatTrack = value;
				PropertySet(this);
			}
		}

		public animAnimNode_AimConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
