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
			get => GetProperty(ref _parentsTransform);
			set => SetProperty(ref _parentsTransform, value);
		}

		[Ordinal(13)] 
		[RED("parentsWeight")] 
		public CArray<CHandle<animIAnimNodeSourceChannel_Float>> ParentsWeight
		{
			get => GetProperty(ref _parentsWeight);
			set => SetProperty(ref _parentsWeight, value);
		}

		[Ordinal(14)] 
		[RED("areSourceChannelsResaved")] 
		public CBool AreSourceChannelsResaved
		{
			get => GetProperty(ref _areSourceChannelsResaved);
			set => SetProperty(ref _areSourceChannelsResaved, value);
		}

		[Ordinal(15)] 
		[RED("parentsTransforms")] 
		public CArray<animAnimNode_MultipleParentConstraint_ParentInfo> ParentsTransforms
		{
			get => GetProperty(ref _parentsTransforms);
			set => SetProperty(ref _parentsTransforms, value);
		}

		[Ordinal(16)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetProperty(ref _transformIndex);
			set => SetProperty(ref _transformIndex, value);
		}

		[Ordinal(17)] 
		[RED("interpolationType")] 
		public CEnum<animEInterpolationType> InterpolationType
		{
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}

		[Ordinal(18)] 
		[RED("weightMode")] 
		public CEnum<animConstraintWeightMode> WeightMode
		{
			get => GetProperty(ref _weightMode);
			set => SetProperty(ref _weightMode, value);
		}

		[Ordinal(19)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(20)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetProperty(ref _weightFloatTrack);
			set => SetProperty(ref _weightFloatTrack, value);
		}

		public animAnimNode_MultipleParentConstraint(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
