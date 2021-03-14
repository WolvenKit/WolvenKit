using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_ParentConstraint : animAnimNode_OnePoseInput
	{
		private CHandle<animIAnimNodeSourceChannel_QsTransform> _parentTransform;
		private CBool _isParentTransformResaved;
		private animTransformIndex _parentTransformIndex;
		private animTransformIndex _transformIndex;
		private CEnum<animEInterpolationType> _interpolationType;
		private CFloat _weight;
		private animNamedTrackIndex _weightFloatTrack;
		private CBool _useBoneReferencePoseAsDefaultOffset;
		private animFloatLink _weightNode;
		private animVectorLink _offsetTranslationLS;
		private animVectorLink _offsetEulerRotationLS;

		[Ordinal(12)] 
		[RED("parentTransform")] 
		public CHandle<animIAnimNodeSourceChannel_QsTransform> ParentTransform
		{
			get
			{
				if (_parentTransform == null)
				{
					_parentTransform = (CHandle<animIAnimNodeSourceChannel_QsTransform>) CR2WTypeManager.Create("handle:animIAnimNodeSourceChannel_QsTransform", "parentTransform", cr2w, this);
				}
				return _parentTransform;
			}
			set
			{
				if (_parentTransform == value)
				{
					return;
				}
				_parentTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("isParentTransformResaved")] 
		public CBool IsParentTransformResaved
		{
			get
			{
				if (_isParentTransformResaved == null)
				{
					_isParentTransformResaved = (CBool) CR2WTypeManager.Create("Bool", "isParentTransformResaved", cr2w, this);
				}
				return _isParentTransformResaved;
			}
			set
			{
				if (_isParentTransformResaved == value)
				{
					return;
				}
				_isParentTransformResaved = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("parentTransformIndex")] 
		public animTransformIndex ParentTransformIndex
		{
			get
			{
				if (_parentTransformIndex == null)
				{
					_parentTransformIndex = (animTransformIndex) CR2WTypeManager.Create("animTransformIndex", "parentTransformIndex", cr2w, this);
				}
				return _parentTransformIndex;
			}
			set
			{
				if (_parentTransformIndex == value)
				{
					return;
				}
				_parentTransformIndex = value;
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
		[RED("interpolationType")] 
		public CEnum<animEInterpolationType> InterpolationType
		{
			get
			{
				if (_interpolationType == null)
				{
					_interpolationType = (CEnum<animEInterpolationType>) CR2WTypeManager.Create("animEInterpolationType", "interpolationType", cr2w, this);
				}
				return _interpolationType;
			}
			set
			{
				if (_interpolationType == value)
				{
					return;
				}
				_interpolationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
		[RED("useBoneReferencePoseAsDefaultOffset")] 
		public CBool UseBoneReferencePoseAsDefaultOffset
		{
			get
			{
				if (_useBoneReferencePoseAsDefaultOffset == null)
				{
					_useBoneReferencePoseAsDefaultOffset = (CBool) CR2WTypeManager.Create("Bool", "useBoneReferencePoseAsDefaultOffset", cr2w, this);
				}
				return _useBoneReferencePoseAsDefaultOffset;
			}
			set
			{
				if (_useBoneReferencePoseAsDefaultOffset == value)
				{
					return;
				}
				_useBoneReferencePoseAsDefaultOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
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

		[Ordinal(21)] 
		[RED("offsetTranslationLS")] 
		public animVectorLink OffsetTranslationLS
		{
			get
			{
				if (_offsetTranslationLS == null)
				{
					_offsetTranslationLS = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "offsetTranslationLS", cr2w, this);
				}
				return _offsetTranslationLS;
			}
			set
			{
				if (_offsetTranslationLS == value)
				{
					return;
				}
				_offsetTranslationLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("offsetEulerRotationLS")] 
		public animVectorLink OffsetEulerRotationLS
		{
			get
			{
				if (_offsetEulerRotationLS == null)
				{
					_offsetEulerRotationLS = (animVectorLink) CR2WTypeManager.Create("animVectorLink", "offsetEulerRotationLS", cr2w, this);
				}
				return _offsetEulerRotationLS;
			}
			set
			{
				if (_offsetEulerRotationLS == value)
				{
					return;
				}
				_offsetEulerRotationLS = value;
				PropertySet(this);
			}
		}

		public animAnimNode_ParentConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
