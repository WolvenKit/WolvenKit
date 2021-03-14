using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MultipleParentConstraint : animAnimNode_OnePoseInput
	{
		private CArray<CHandle<animIAnimNodeSourceChannel_QsTransform>> _parentsTransform;
		private CArray<CHandle<animIAnimNodeSourceChannel_Float>> _parentsWeight;
		private CBool _areSourceChannelsResaved;
		private CArray<animAnimNode_MultipleParentConstraint_ParentInfo> _parentsTransforms;
		private animTransformIndex _transformIndex;
		private CEnum<animEInterpolationType> _interpolationType;
		private CEnum<animConstraintWeightMode> _weightMode;
		private CFloat _weight;
		private animNamedTrackIndex _weightFloatTrack;

		[Ordinal(12)] 
		[RED("parentsTransform")] 
		public CArray<CHandle<animIAnimNodeSourceChannel_QsTransform>> ParentsTransform
		{
			get
			{
				if (_parentsTransform == null)
				{
					_parentsTransform = (CArray<CHandle<animIAnimNodeSourceChannel_QsTransform>>) CR2WTypeManager.Create("array:handle:animIAnimNodeSourceChannel_QsTransform", "parentsTransform", cr2w, this);
				}
				return _parentsTransform;
			}
			set
			{
				if (_parentsTransform == value)
				{
					return;
				}
				_parentsTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("parentsWeight")] 
		public CArray<CHandle<animIAnimNodeSourceChannel_Float>> ParentsWeight
		{
			get
			{
				if (_parentsWeight == null)
				{
					_parentsWeight = (CArray<CHandle<animIAnimNodeSourceChannel_Float>>) CR2WTypeManager.Create("array:handle:animIAnimNodeSourceChannel_Float", "parentsWeight", cr2w, this);
				}
				return _parentsWeight;
			}
			set
			{
				if (_parentsWeight == value)
				{
					return;
				}
				_parentsWeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("parentsTransforms")] 
		public CArray<animAnimNode_MultipleParentConstraint_ParentInfo> ParentsTransforms
		{
			get
			{
				if (_parentsTransforms == null)
				{
					_parentsTransforms = (CArray<animAnimNode_MultipleParentConstraint_ParentInfo>) CR2WTypeManager.Create("array:animAnimNode_MultipleParentConstraint_ParentInfo", "parentsTransforms", cr2w, this);
				}
				return _parentsTransforms;
			}
			set
			{
				if (_parentsTransforms == value)
				{
					return;
				}
				_parentsTransforms = value;
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

		[Ordinal(18)] 
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

		[Ordinal(19)] 
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

		[Ordinal(20)] 
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

		public animAnimNode_MultipleParentConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
