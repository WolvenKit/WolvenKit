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
			get => GetProperty(ref _parentTransform);
			set => SetProperty(ref _parentTransform, value);
		}

		[Ordinal(13)] 
		[RED("isParentTransformResaved")] 
		public CBool IsParentTransformResaved
		{
			get => GetProperty(ref _isParentTransformResaved);
			set => SetProperty(ref _isParentTransformResaved, value);
		}

		[Ordinal(14)] 
		[RED("parentTransformIndex")] 
		public animTransformIndex ParentTransformIndex
		{
			get => GetProperty(ref _parentTransformIndex);
			set => SetProperty(ref _parentTransformIndex, value);
		}

		[Ordinal(15)] 
		[RED("transformIndex")] 
		public animTransformIndex TransformIndex
		{
			get => GetProperty(ref _transformIndex);
			set => SetProperty(ref _transformIndex, value);
		}

		[Ordinal(16)] 
		[RED("interpolationType")] 
		public CEnum<animEInterpolationType> InterpolationType
		{
			get => GetProperty(ref _interpolationType);
			set => SetProperty(ref _interpolationType, value);
		}

		[Ordinal(17)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(18)] 
		[RED("weightFloatTrack")] 
		public animNamedTrackIndex WeightFloatTrack
		{
			get => GetProperty(ref _weightFloatTrack);
			set => SetProperty(ref _weightFloatTrack, value);
		}

		[Ordinal(19)] 
		[RED("useBoneReferencePoseAsDefaultOffset")] 
		public CBool UseBoneReferencePoseAsDefaultOffset
		{
			get => GetProperty(ref _useBoneReferencePoseAsDefaultOffset);
			set => SetProperty(ref _useBoneReferencePoseAsDefaultOffset, value);
		}

		[Ordinal(20)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		[Ordinal(21)] 
		[RED("offsetTranslationLS")] 
		public animVectorLink OffsetTranslationLS
		{
			get => GetProperty(ref _offsetTranslationLS);
			set => SetProperty(ref _offsetTranslationLS, value);
		}

		[Ordinal(22)] 
		[RED("offsetEulerRotationLS")] 
		public animVectorLink OffsetEulerRotationLS
		{
			get => GetProperty(ref _offsetEulerRotationLS);
			set => SetProperty(ref _offsetEulerRotationLS, value);
		}

		public animAnimNode_ParentConstraint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
