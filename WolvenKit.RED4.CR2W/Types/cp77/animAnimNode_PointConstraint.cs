using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_PointConstraint : animAnimNode_OnePoseInput
	{
		private CBool _areSourceChannelsResaved;
		private CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> _inputTransforms;
		private CArray<CFloat> _preprocessedWeights;
		private CArray<animAnimNode_PointConstraint_WeightedTransform> _inputWeightedTransforms;
		private animTransformIndex _transformIndex;
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
		[RED("inputTransforms")] 
		public CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> InputTransforms
		{
			get
			{
				if (_inputTransforms == null)
				{
					_inputTransforms = (CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>>) CR2WTypeManager.Create("array:handle:animAnimNodeSourceChannel_WeightedVector", "inputTransforms", cr2w, this);
				}
				return _inputTransforms;
			}
			set
			{
				if (_inputTransforms == value)
				{
					return;
				}
				_inputTransforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("preprocessedWeights")] 
		public CArray<CFloat> PreprocessedWeights
		{
			get
			{
				if (_preprocessedWeights == null)
				{
					_preprocessedWeights = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "preprocessedWeights", cr2w, this);
				}
				return _preprocessedWeights;
			}
			set
			{
				if (_preprocessedWeights == value)
				{
					return;
				}
				_preprocessedWeights = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("inputWeightedTransforms")] 
		public CArray<animAnimNode_PointConstraint_WeightedTransform> InputWeightedTransforms
		{
			get
			{
				if (_inputWeightedTransforms == null)
				{
					_inputWeightedTransforms = (CArray<animAnimNode_PointConstraint_WeightedTransform>) CR2WTypeManager.Create("array:animAnimNode_PointConstraint_WeightedTransform", "inputWeightedTransforms", cr2w, this);
				}
				return _inputWeightedTransforms;
			}
			set
			{
				if (_inputWeightedTransforms == value)
				{
					return;
				}
				_inputWeightedTransforms = value;
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

		public animAnimNode_PointConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
