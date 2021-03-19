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
			get => GetProperty(ref _areSourceChannelsResaved);
			set => SetProperty(ref _areSourceChannelsResaved, value);
		}

		[Ordinal(13)] 
		[RED("inputTransforms")] 
		public CArray<CHandle<animAnimNodeSourceChannel_WeightedVector>> InputTransforms
		{
			get => GetProperty(ref _inputTransforms);
			set => SetProperty(ref _inputTransforms, value);
		}

		[Ordinal(14)] 
		[RED("preprocessedWeights")] 
		public CArray<CFloat> PreprocessedWeights
		{
			get => GetProperty(ref _preprocessedWeights);
			set => SetProperty(ref _preprocessedWeights, value);
		}

		[Ordinal(15)] 
		[RED("inputWeightedTransforms")] 
		public CArray<animAnimNode_PointConstraint_WeightedTransform> InputWeightedTransforms
		{
			get => GetProperty(ref _inputWeightedTransforms);
			set => SetProperty(ref _inputWeightedTransforms, value);
		}

		[Ordinal(16)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetProperty(ref _transformIndex);
			set => SetProperty(ref _transformIndex, value);
		}

		[Ordinal(17)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetProperty(ref _weightMode);
			set => SetProperty(ref _weightMode, value);
		}

		[Ordinal(18)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(19)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetProperty(ref _weightFloatTrack);
			set => SetProperty(ref _weightFloatTrack, value);
		}

		public animAnimNode_PointConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
